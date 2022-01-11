using BusinessLayer;
using DataLayer;
using DataLayer.Repositories;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace PresentationLayerWeb
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            container.RegisterType<IAdminRepository, AdminRepository>();
            container.RegisterType<IAdminBusiness, AdminBusiness>();
            container.RegisterType<IDoctorRepository, DoctorRepository>();
            container.RegisterType<IDoctorBusiness, DoctorBusiness>();
            container.RegisterType<IPatientRepository, PatientRepository>();
            container.RegisterType<IPatientBusiness, PatientBusiness>();
        }
    }
}