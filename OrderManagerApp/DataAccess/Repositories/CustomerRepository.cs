using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

                using(var command = new SqlCommand(sql, connection))
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        string email = reader.GetString(reader.GetOrdinal("Email"));

                        Customer customer = new(firstName, lastName, email);
                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }
    }
}
