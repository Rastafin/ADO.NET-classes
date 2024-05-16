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

                    string ordersSql = "SELECT Id FROM Orders WHERE Status = 1";
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

        public Order GetOrderByPaymentId(int paymentId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = @"SELECT Orders.* FROM Orders
                        INNER JOIN Payments ON Orders.Id = Payments.OrderId
                        WHERE Payments.Id = @PaymentId;";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", paymentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        if (dataSet.Tables["Orders"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Orders"]!.Rows[0];

                            int id = (int)row["Id"];
                            int customerId = (int)row["CustomerId"];
                            DateTime orderDate = (DateTime)row["OrderDate"];
                            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), row["Status"].ToString()!);

                            return new Order(id, customerId, orderDate, orderStatus);
                        }
                        else
                        {
                            throw new Exception($"Order with PaymentId: {paymentId} cannot be found.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred while trying to get order by PaymentId. " + (ex.Message));
            }
        }
    }
}
