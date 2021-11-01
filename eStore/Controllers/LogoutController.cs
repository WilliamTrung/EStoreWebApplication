using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Login");
        }
    }
}
