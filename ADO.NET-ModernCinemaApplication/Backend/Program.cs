using Backend.Data;
using Backend.Entities;
using Backend.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<DbConnectionFactory>();

UserRepository _userRepository = new UserRepository();

List<User> users = _userRepository.GetAllUsers();

foreach (User user in users)
{
    Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Email: {user.Email}, Status: {user.Status.ToString()}," +
        $" Role: {user.Role}");
}