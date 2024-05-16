using DataAccess.Data;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Models.Enums;

namespace DataAccess.Repositories
{
    public class OrderRepository() : IOrderRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public List<int> GetMissingOrderIdsInPayments()
        {
            List<int> missingOrderIds = new List<int>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string ordersSql = "SELECT Id FROM Orders";
                    DataTable ordersTable = new DataTable();

                    using (var ordersCommand = new SqlCommand(ordersSql, connection))
                    {
                        SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersCommand);
                        ordersAdapter.Fill(ordersTable);
                    }

                    string paymentsSql = "SELECT OrderId FROM Payments";
                    DataTable paymentsTable = new DataTable();
                    using (var paymentsCommand = new SqlCommand(paymentsSql, connection))
                    {
                        SqlDataAdapter paymentsAdapter = new SqlDataAdapter(paymentsCommand);
                        paymentsAdapter.Fill(paymentsTable);
                    }

                    var allOrderIds = ordersTable.AsEnumerable().Select(r => r.Field<int>("Id"));
                    var paymentsOrderIds = paymentsTable.AsEnumerable().Select(r => r.Field<int>("OrderId"));
                    missingOrderIds = allOrderIds.Except(paymentsOrderIds).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get missing OrderIds in Payments. " + ex.Message);
            }

            return missingOrderIds;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Orders";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            int customerId = (int)row["CustomerId"];
                            DateTime dateTime = (DateTime)row["OrderDate"];
                            OrderStatus orderStatus = (OrderStatus)row["OrderStatus"];

                            Order order = new Order(id, customerId, dateTime, orderStatus);
                            orders.Add(order);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all orders. " + ex.Message);
            }

            return orders;

        }
        public void AddToOrder(Order order)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM ORDERS";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        DataRow newRow = dataSet.Tables[0].NewRow();
                        newRow["CustomerId"] = order.CustomerId;
                        newRow["OrderDate"] = order.OrderDate;
                        newRow["OrderSatus"] = order.Status;

                        dataSet.Tables[0].Rows.Add(newRow);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "Orders");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new orders. " + ex.Message);
            }


        }
    

        public void DeleteOrder(int Id)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM Orders WHERE Id= @Id ";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");


                        if (dataSet.Tables["Orders"]!.Rows.Count == 1)
                        {
                            dataSet.Tables["Orders"]!.Rows[0].Delete();

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Orders");
                        }
                        else
                        {
                            throw new Exception("Order with specified ID not found.");
                        }



                    }


                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to delete order." + ex.Message);
            }

        }

        public void ChangeStatus(Order order)
        {

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {

                    connection.Open();
                    string query = "SELECT * FROM ORDERS WHERE Id = @Id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", order.Id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        if (dataSet.Tables["Orders"].Rows.Count == 1)
                        {
                            DataRow dataRow = dataSet.Tables["Orders"]!.Rows[0];
                            dataRow["OrderStatus"] = order.Status;

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Orders");

                        }
                        else
                        {
                            throw new Exception("Order with specified ID not found.");
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while trying to update order. " + ex.Message);
            }
        }
    }
}

