using Microsoft.Extensions.Hosting;
using Host = Microsoft.Extensions.Hosting.Host;
using MassTransit;
using Core.Consumers;
using Microsoft.Extensions.DependencyInjection;
using Core.Application.Services;

namespace Core.BrokerConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Hello, World!");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .ConfigureServices((hostContext, services) =>
          {
              services.AddSingleton<IAccountService, AccountService>();

              services.AddMassTransit(x =>
              {
                  x.AddConsumer<CreateAccountConsumer>(); 
                  
                  x.UsingRabbitMq((context, cfg) =>
                  {
                      cfg.Host("localhost");
                      cfg.ConfigureEndpoints(context);
                  });
              });
          }); 
    
    }
    
}
