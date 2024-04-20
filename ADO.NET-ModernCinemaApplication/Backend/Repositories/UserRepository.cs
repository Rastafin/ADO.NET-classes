using Backend.Data;
using Backend.Entities;
using Backend.Entities.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class UserRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Users";

                using (var command = new SqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string login = reader.GetString(reader.GetOrdinal("Login"));
                        string password = reader.GetString(reader.GetOrdinal("Password"));
                        string email = reader.GetString(reader.GetOrdinal("Email"));
                        Status status = (Status)reader.GetInt32(reader.GetOrdinal("Status"));
                        Role role = (Role)reader.GetInt32(reader.GetOrdinal("Role"));

                        User user = new User
                        {
                            Id = id,
                            Login = login,
                            Password = password,
                            Email = email,
                            Status = status,
                            Role = role
                        };

                        users.Add(user);
                    }
                }
            }

            return users;
        }
    }
}
