using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore
{
    public static class JsonInteract
    {
        public static IConfiguration Configuration;

        public static Member GetAdminAccount()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            var adminDefaultSettings = Configuration.GetSection("AdminAccount").Get<Member>();
            return adminDefaultSettings;
        }
    }
}
