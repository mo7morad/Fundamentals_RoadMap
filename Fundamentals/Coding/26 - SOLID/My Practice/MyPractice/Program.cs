using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Trail
{
    public interface IService
    {
        string ServiceName { get; }
        string Description { get; }
        Task ExecuteAsync(ServiceContext context);
    }

    public class ServiceContext
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
    }

    public class SaveService : IService
    {
        public string ServiceName => "Save Service";
        public string Description => "Saves user data to DataBase.";

        public async Task ExecuteAsync(ServiceContext context)
        {
            Console.WriteLine($"User {context.UserName} saved to database at {context.RegisteredAt}.");
        }
    }

    public class EmailService : IService
    {
        public string ServiceName => "Email Service";
        public string Description => "Sends emails to users.";

        public async Task ExecuteAsync(ServiceContext context)
        {
            Console.WriteLine($"Sending email to {context.Email}...");
            await Task.Delay(2000); // Simulate 2-second email sending
            Console.WriteLine($"Email sent to {context.Email} for user {context.UserName}.");
        }
    }


    public class LogService : IService
    {
        public string ServiceName => "Logging Service";
        public string Description => "Logs new registered users.";

        public async Task ExecuteAsync(ServiceContext context)
        {
            Console.WriteLine($"User {context.UserName} is being registered at {context.RegisteredAt}.");
            await Task.Delay(1000); // Simulate 1-second logging
            Console.WriteLine($"User Logging done successfully.");
        }
    }

    public class UserService
    {
        private readonly List<IService> _services;

        public UserService(List<IService> services)
        {
            _services = services;
        }

        public async Task RegisterAsync(string username, string password, string email)
        {
            Console.WriteLine($"User {username} registered with password {password}.");

            var context = new ServiceContext
            {
                UserName = username,
                Email = email,
                RegisteredAt = DateTime.Now
            };

            foreach (var service in _services)
            {
                await service.ExecuteAsync(context);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new List<IService>
            {
                new SaveService(),
                new EmailService(),
                new LogService()
            };

            var userService = new UserService(services);
            userService.RegisterAsync("Morad", "1234", "morad@example.com");
        }
    }
}
