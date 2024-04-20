using Backend.Data;
using Backend.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Birthday { get; set; }
        public Sex? Sex { get; set; }
        public string? PhoneNumber { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? ZipCode { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        public Person() { }

        public Person(string name, string lastName, string birthday, Sex sex, string phoneNumber, string country, string city,
            string street, string houseNumber, string zipCode)
        {
            Name = name;
            LastName = lastName;
            Birthday = birthday;
            Sex = sex;
            PhoneNumber = phoneNumber;
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
        }


        public static void AddClientWithUser(Person client, User user)
        {
            using (var context = new DataContext())
            {
                using var transaction = context.Database.BeginTransaction();

                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();

                    client.UserId = user.Id;
                    context.Clients.Add(client);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static void UpdateClient(Person updatedClient)
        {
            using (var context = new DataContext())
            {       
                try
                {
                    Person? existingClient = context.Clients.Include(r => r.User).FirstOrDefault(c => c.Id == updatedClient.Id);

                    if (existingClient == null) throw new Exception();

                    context.Entry(existingClient).CurrentValues.SetValues(updatedClient);
                    context.Entry(existingClient.User).CurrentValues.SetValues(updatedClient.User);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static Person GetClient(int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Clients.Include(r => r.User)
                        .FirstOrDefault(c => c.User.Id == userId);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public static List<Person> GetClients()
        {
            using(var context = new DataContext())
            {
                try
                {
                    return context.Clients.Include(r => r.User)
                        .ToList();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public static List<(Person client, int age)> GetClientsWithAge()
        {
            using(var context = new DataContext())
            {
                try
                {
                    var clients = context.Clients.Include(c => c.User).ToList();
                    var clientsWithAge = new List<(Person client, int age)>();

                    foreach(var client in clients)
                    {
                        DateTime birthDate = DateTime.ParseExact(client.Birthday, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                        DateTime now = DateTime.Today;

                        int age = now.Year - birthDate.Year;

                        if(now < birthDate.AddYears(age))
                        {
                            age--;
                        }

                        clientsWithAge.Add((client, age));
                    }

                    return clientsWithAge;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetClientsWithAge method. " + ex.Message);
                }
            }
        }
    }
}
