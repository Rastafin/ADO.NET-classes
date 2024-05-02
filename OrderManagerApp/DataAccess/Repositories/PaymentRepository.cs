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
                       JOIN OrderDetails ON Orders.Id = OrderDetails.OrderId
                       JOIN Products ON OrderDetails.ProductId = Products.Id
                       WHERE Orders.Id = @OrderId";

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
                throw new Exception("An error occurred while calculating total amount for order. " + ex.Message);
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
                            int id = (int)row["Id"];
                            int orderId = (int)row["OrderId"];
                            decimal amount = (decimal)row["Amount"];
                            DateTime paymentDate = (DateTime)row["PaymentDate"];
                            PaymentStatus status = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), row["Status"].ToString());

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
    }
}
