using BusinessLayer;
using DataLayer;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(login);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminBusiness, AdminBusiness>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorBusiness, DoctorBusiness>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IPatientBusiness, PatientBusiness>();
            services.AddScoped<LoginForm>();
        }
    }
    
}
