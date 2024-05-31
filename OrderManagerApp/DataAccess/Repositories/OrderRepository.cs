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

                    string ordersSql = "SELECT OrderId FROM Orders WHERE Status = 1";
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

                    var allOrderIds = ordersTable.AsEnumerable().Select(r => r.Field<int>("OrderId"));
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
                    string sql = "SELECT * FROM Orders ORDER BY OrderDate DESC";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["OrderId"];
                            int customerId = (int)row["CustomerId"];
                            DateTime dateTime = (DateTime)row["OrderDate"];
                            OrderStatus orderStatus = (OrderStatus)row["Status"];

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

        public Order GetOrderByPaymentId(int paymentId)
        {

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string sql = @"SELECT Orders.* FROM Orders
                        INNER JOIN Payments ON Orders.OrderId = Payments.OrderId
                        WHERE Payments.PaymentId = @PaymentId;";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", paymentId);


                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");
                        if (dataSet.Tables["Orders"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Orders"]!.Rows[0];

                            int id = (int)row["OrderId"];
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
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get order by PaymentId. " + (ex.Message));
            }
        }


        public int AddOrder(Order order)

        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string insertOrderQuery = @"
                            INSERT INTO Orders (CustomerId, OrderDate, Status)
                            VALUES (@CustomerId, @OrderDate, @OrderStatus);
                            SELECT SCOPE_IDENTITY();";

                        using (var command = new SqlCommand(insertOrderQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                            command.Parameters.AddWithValue("@OrderStatus", order.Status);

                            int orderId = Convert.ToInt32(command.ExecuteScalar());

                            transaction.Commit();

                            return orderId;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while trying to add new order and get order ID. " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new order. " + ex.Message);
            }
        }


        public void DeleteOrder(int Id)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM Orders WHERE OrderId= @Id ";

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

        public void ChangeStatus(int orderId, OrderStatus orderStatus)
        {  
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {

                    connection.Open();
                    string query = "SELECT * FROM ORDERS WHERE OrderId = @Id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", orderId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        if (dataSet.Tables["Orders"]!.Rows.Count == 1)
                        {
                            DataRow dataRow = dataSet.Tables["Orders"]!.Rows[0];
                            dataRow["Status"] = orderStatus;
                            dataRow["OrderDate"] = DateTime.Now;

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

        public Order GetOrderById(int orderId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Orders WHERE OrderId = @OrderId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Order");

                        if (dataSet.Tables["Order"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Order"]!.Rows[0];

                            int id = (int)row["OrderId"];
                            int customerId = (int)row["CustomerId"];
                            DateTime orderDate = (DateTime)row["OrderDate"];
                            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), row["Status"].ToString()!);

                            return new Order(id, customerId, orderDate, status);
                        }
                        else
                        {
                            throw new Exception($"Order with Id: {orderId} cannot be found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while trying to get order with Id: {orderId}. " + ex.Message);
            }
        }

        public List<int> GetOrdersToDeliverIds()
        {
            List<int> orderIds = new List<int>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = @"SELECT Orders.* FROM Orders
                            INNER JOIN Payments ON Payments.OrderId = Orders.OrderId
                            WHERE Payments.Status = 0 AND Orders.Status = 1;";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Orders");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["OrderId"];

                            orderIds.Add(id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all order to deliver Ids. " + ex.Message);
            }

            return orderIds;
        }
    }
}

