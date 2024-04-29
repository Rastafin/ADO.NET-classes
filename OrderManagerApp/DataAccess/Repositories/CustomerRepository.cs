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

            using(var connection = _connectionFactory.CreateConnection())
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

                        Customer customer = new Customer(firstName, lastName, email);
                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }
    }
}
