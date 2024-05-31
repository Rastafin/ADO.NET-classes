using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PaymentRepository() : IPaymentRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public decimal CalculateTotalAmountForOrder(int orderId)
        {
            try
            {
                string sql = @"SELECT SUM(Products.Price * OrderDetails.Quantity) 
                       FROM Orders
                       JOIN OrderDetails ON Orders.OrderId = OrderDetails.OrderId
                       JOIN Products ON OrderDetails.ProductId = Products.ProductId
                       WHERE Orders.OrderId = @OrderId";

                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        object result = command.ExecuteScalar();

                        if (result == DBNull.Value || result == null)
                        {
                            throw new Exception();
                        }

                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"An error occurred while calculating total amount for order: {orderId}. " + ex.Message);
            }
        }

        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Payments";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Payments");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["PaymentId"];
                            int orderId = (int)row["OrderId"];
                            decimal amount = (decimal)row["Amount"];
                            DateTime paymentDate = (DateTime)row["PaymentDate"];
                            PaymentStatus status = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), row["Status"].ToString()!);

                            Payment payment = new Payment(id, orderId, amount, paymentDate, status);
                            payments.Add(payment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all payments. " + ex.Message);
            }

            return payments;
        }

        public void AddPayment(Payment payment)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Payments";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Payments");

                        DataRow newRow = dataSet.Tables[0].NewRow();
                        newRow["OrderId"] = payment.OrderId;
                        newRow["Amount"] = payment.Amount;
                        newRow["PaymentDate"] = payment.PaymentDate;
                        newRow["Status"] = payment.Status;

                        dataSet.Tables[0].Rows.Add(newRow);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "Payments");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new payment. " + ex.Message);
            }
        }

        public List<int> GetPaymentIdsWithStatusWaiting()
        {
            List<int> paymentIds = new List<int>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string sql = "SELECT PaymentId FROM Payments WHERE Status = @Status";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Status", PaymentStatus.Waiting);

                        SqlDataAdapter ordersAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        ordersAdapter.Fill(dataSet);

                        foreach(DataRow row in dataSet.Tables[0].Rows)
                        {
                            paymentIds.Add((int)row["PaymentId"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get payment IDs with status Waiting. " + ex.Message);
            }

            return paymentIds;
        }

        public void SettlePayment(int paymentId, decimal amount)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Payments WHERE PaymentId = @PaymentId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", paymentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Payments");

                        if (dataSet.Tables["Payments"]!.Rows.Count == 1)
                        {
                            DataRow row = dataSet.Tables[0].Rows[0];
                            decimal currentAmount = (decimal)row["Amount"];
                            decimal updatedAmount = currentAmount - amount;

                            if (updatedAmount < 0)
                            {
                                throw new Exception("Payment amount sent is too high. ");
                            }

                            row["Amount"] = updatedAmount;
                            row["PaymentDate"] = DateTime.Now;

                            if (updatedAmount == 0)
                            {
                                row["Status"] = PaymentStatus.Paid;
                            }

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Payments");
                        }
                        else
                        {
                            throw new Exception("Payment with specified ID not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while settling payment. " + ex.Message);
            }
        }

        public decimal GetMaxSettlementAmount(int paymentId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT Amount FROM Payments WHERE PaymentId = @PaymentId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", paymentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            return (decimal)dataSet.Tables[0].Rows[0]["Amount"];
                        }
                        else
                        {
                            throw new Exception("Payment not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get maximum settlement amount. " + ex.Message);
            }
        }

        public Payment GetPaymentById(int paymentId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Payments WHERE PaymentId = @PaymentId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", paymentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Payment");

                        if (dataSet.Tables["Payment"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Payment"]!.Rows[0];

                            int id = (int)row["PaymentId"];
                            int orderId = (int)row["OrderId"];
                            decimal amount = (decimal)row["Amount"];
                            DateTime paymentDate = (DateTime)row["PaymentDate"];
                            PaymentStatus status = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), row["Status"].ToString()!);

                            return new Payment(id, orderId, amount, paymentDate, status);
                        }
                        else
                        {
                            throw new Exception($"Payment with Id: {paymentId} cannot be found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get payment by id. " + ex.Message);
            }
        }

        public void UpdatePayment(Payment payment)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Payments WHERE PaymentId = @Id";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", payment.PaymentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Payments");

                        if (dataSet.Tables["Payments"]!.Rows.Count == 1)
                        {
                            DataRow row = dataSet.Tables["Payments"]!.Rows[0];

                            row["OrderId"] = payment.OrderId;
                            row["Amount"] = payment.Amount;
                            row["PaymentDate"] = payment.PaymentDate;
                            row["Status"] = payment.Status;

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Payments");
                        }
                        else
                        {
                            throw new Exception("Payment with specified ID not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to update payment. " + ex.Message);
            }
        }
    }
}
