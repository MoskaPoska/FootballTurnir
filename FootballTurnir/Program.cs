using FootballTurnir.DAL;
using FootballTurnir.DAL.Repository;
using FootballTurnir.DAL.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FootballTurnir
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var host = Configuration().Build();

            var context = host.Services.GetRequiredService<FootballTurnirContext>();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(context));

        }
        public static IHostBuilder Configuration()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, service) =>
            {
                service.AddDbContext<FootballTurnirContext>(t =>
                    t.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                service.AddScoped<ClubRepository>();
                service.AddScoped<ClubService>();
            });
        }
    }
}