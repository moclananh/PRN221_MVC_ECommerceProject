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
    public class AccountsInforController : Controller
    {
        private readonly PRN221_ASM02Context _context;

        public AccountsInforController(PRN221_ASM02Context context)
        {
            _context = context;
        }

        // GET: AccountsInfor
        public async Task<IActionResult> Details()
        {
            return View(await _context.Accounts.ToListAsync());
        }



        // GET: AccountsInfor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }
        // GET: AccountsInfor
        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(a => a.AccountId == id);
        }
        // POST: AccountsInfor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountId,UserName,Password,FullName,Type")] Account account)
        {
            if (id != account.AccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.AccountId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "AccountsInfor");
            }
            return View(account);
        }

    }
}
