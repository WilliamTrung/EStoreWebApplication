using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore.Controllers
{
    public class LoginController : Controller
    {
        private readonly FStoreContext _context;

        public LoginController(FStoreContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult CheckLogin(string email, string password)
        {
            Member admin = JsonInteract.GetAdminAccount();
            if(admin.Email == email && admin.Password == password)
            {
                HttpContext.Session.SetString("role","Admin");
                HttpContext.Session.SetString("email", "Admin");
                return RedirectToAction("Index", "Home");
            }
            Member loginUser = _context.Members.FirstOrDefault(m => m.Email == email && m.Password == password);
            if(loginUser == null)
            {
                
                return RedirectToAction("Login", "Login");
            }
            else
            {
                HttpContext.Session.SetString("role", "User");
                HttpContext.Session.SetString("email", email);
                HttpContext.Session.SetInt32("id", loginUser.MemberId);
                return RedirectToAction("Home", "User");
            }
            
        }
    }
}
