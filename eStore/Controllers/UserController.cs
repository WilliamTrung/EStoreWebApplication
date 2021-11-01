using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore.Controllers
{
    public class UserController : Controller
    {
        private readonly FStoreContext _context;
        private Member LoginUser()
        {
            int?id = HttpContext.Session.GetInt32("id");
            var member = _context.Members.SingleOrDefault(m => m.MemberId == id);
            return member;
        }
        public UserController(FStoreContext context)
        {
            _context = context;
        }
        public IActionResult Home()
        {
            var member = LoginUser();
            if (member == null)
            {
                return NotFound();
            } 
            return View(member);
        }
        //Get Order
        public IActionResult OrderHistory()
        {
            var orders = _context.Orders.Where(o => o.MemberId == LoginUser().MemberId).OrderByDescending(o => o.OrderDate);

            return View(orders);
        }
        //Get OrderDetail
        public async Task<IActionResult> OrderDetails(int id)
        {
            //var fStoreContext = _context.OrderDetails.Include(o => o.Order).Include(o => o.Product);
            var fStoreContext = _context.OrderDetails.Where(d => d.OrderId == id).OrderBy(d => d.Order.OrderDate);
            ViewData["OrderId"] = id;
            foreach (var detail in fStoreContext)
            {
                detail.Product = _context.Products.FindAsync(detail.ProductId).Result;
                detail.Order = _context.Orders.FindAsync(detail.OrderId).Result;
            }
            return View(await fStoreContext.ToListAsync());
        }
        // GET: Members/Edit/5
        public async Task<IActionResult> Edit()
        {
            var member = await _context.Members.FindAsync(LoginUser().MemberId);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberId,Email,CompanyName,City,Country,Password")] Member member)
        {
            if (id != member.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.MemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Home));
            }
            return View(member);
        }
        private bool MemberExists(int id)
        {
            return _context.Members.Any(e => e.MemberId == id);
        }
    }
}
