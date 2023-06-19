using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN221_Asm02.Models;

namespace PRN221_Asm02.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly PRN221_ASM02Context _context;

        public StatisticController(PRN221_ASM02Context context)
        {
            _context = context;
        }

        // GET: Statistic
        public ActionResult Index()
        {
            return View();
        }

        // GET: Statistic/Details/5
        public async Task<IActionResult> ThongKe(DateTime startDate, DateTime endDate)
        {
            string startDate1 = startDate.ToString();
            string endDate1 = endDate.ToString();
            var orders = await _context.Orders.ToListAsync();
            HttpContext.Session.SetString("StartDate", startDate1);
            HttpContext.Session.SetString("EndDate", endDate1);

            return View(orders);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Orders
                .Include(b => b.Customer)
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
