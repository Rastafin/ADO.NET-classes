using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Enums;

namespace DataAccess.Repositories
{
    public class OrderDetailsRepository() : IOrderDetailsRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM OrderDetails";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "OrderDetails");

                        DataRow newRow = dataSet.Tables[0].NewRow();
                        newRow["OrderId"] = orderDetails.OrderId;
                        newRow["ProductId"] = orderDetails.ProductId;
                        newRow["Quantity"] = orderDetails.Quantity;

                        dataSet.Tables[0].Rows.Add(newRow);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "OrderDetails");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new orderDetails. " + ex.Message);
            }
        }

        public List<OrderDetails> GetOrderDetailsForOrder(int orderId)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM OrderDetails WHERE OrderId = @OrderId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "OrderDetails");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            int orderIdFromRow = (int)row["OrderId"];
                            int productId = (int)row["ProductId"];
                            int quantity = (int)row["Quantity"];

                            OrderDetails orderDetail = new OrderDetails(id, orderIdFromRow, productId, quantity);
                            orderDetails.Add(orderDetail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while trying to get orderDetails for order with id: {orderId}. " + ex.Message);
            }

            return orderDetails;
        }

        public void DeleteOrderDetails(int orderDetailsId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM OrderDetails WHERE Id = @Id";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", orderDetailsId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "OrderDetails");

                    if (dataSet.Tables["OrderDetails"]!.Rows.Count == 1)
                    {
                        dataSet.Tables["OrderDetails"]!.Rows[0].Delete();

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "OrderDetails");
                    }
                    else
                    {
                        throw new Exception("OrderDetails with specified ID not found.");
                    }
                }
            }
        }
    }
}
