using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp
{
    static class LoadJson
    {
        
        public static Member GetAdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            var adminDefaultSettings = config.GetSection("AdminAccount").Get<Member>();
            return adminDefaultSettings;
        }
    }
}
