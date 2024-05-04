using DataAccess.Data;
using DataAccess.Models;
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
    public class CustomerRepository() : ICustomerRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customers";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Customers");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            string firstName = (string)row["FirstName"];
                            string lastName = (string)row["LastName"];
                            string email = (string)row["Email"];

                            Customer customer = new Customer(id, firstName, lastName, email);
                            customers.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all customers. " + ex.Message);
            }

            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customers";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Customers");

                        DataRow newRow = dataSet.Tables[0].NewRow();
                        newRow["FirstName"] = customer.FirstName;
                        newRow["LastName"] = customer.LastName;
                        newRow["Email"] = customer.Email;

                        dataSet.Tables[0].Rows.Add(newRow);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "Customers");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new customer. " + ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customers WHERE Id = @Id";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", customer.Id);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Customers");

                        if (dataSet.Tables["Customers"]!.Rows.Count == 1)
                        {
                            DataRow row = dataSet.Tables["Customers"]!.Rows[0];
                            row["FirstName"] = customer.FirstName;
                            row["LastName"] = customer.LastName;
                            row["Email"] = customer.Email;

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Customers");
                        }
                        else
                        {
                            throw new Exception("Customer with specified ID not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to update customer. " + ex.Message);
            }
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customers WHERE Id = @Id";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", customerId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Customers");

                        if (dataSet.Tables["Customers"]!.Rows.Count == 1)
                        {
                            dataSet.Tables["Customers"]!.Rows[0].Delete();

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Customers");
                        }
                        else
                        {
                            throw new Exception("Customer with specified ID not found.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred while trying to delete customer. " + ex.Message);
            }
        }

        public Customer GetCustomerByOrderId(int orderId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT Customers.* FROM Customers JOIN Orders ON Customers.Id = Orders.CustomerId WHERE Orders.Id = @OrderId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Customers");

                        if (dataSet.Tables["Customers"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Customers"]!.Rows[0];

                            int id = (int)row["Id"];
                            string firstName = (string)row["FirstName"];
                            string lastName = (string)row["LastName"];
                            string email = (string)row["Email"];

                            return new Customer(id, firstName, lastName, email);
                        }
                        else
                        {
                            throw new Exception($"Customer connected with order: {orderId} cannot be found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get customer. " + ex.Message);
            }

        }
    }
}
