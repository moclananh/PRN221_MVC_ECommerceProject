using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN221_Asm02.Models;

namespace PRN221_Asm02.Controllers
{
    public class OrdersController : Controller
    {
        private readonly PRN221_ASM02Context _context;

        public OrdersController(PRN221_ASM02Context context)
        {
            _context = context;
        }

        // GET: Bills
        public async Task<IActionResult> Index()
        {

            var PRN221_ASM02Context = _context.Orders.Include(b => b.CustomerId);
            return View(await PRN221_ASM02Context.ToListAsync());
        }

        // GET: Bills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Orders
                .Include(b => b.CustomerId)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (bill == null)
            {
                return NotFound();
            }

            var chitietbill = _context.OrderDetails
              .AsNoTracking()
              .Where(x => x.OrderId == bill.OrderId)
              .OrderBy(x => x.OrderId).ToList();
            ViewBag.ChiTiet = chitietbill;

            return View(bill);
        }
    }
}
