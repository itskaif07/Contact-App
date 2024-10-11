using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contact.Data;
using Contact.Models;

namespace Contact.Controllers
{
    public class ContactItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ContactItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactItems.ToListAsync());
        }

        // GET: ContactItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactItem = await _context.ContactItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactItem == null)
            {
                return NotFound();
            }

            return View(contactItem);
        }

        // GET: ContactItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContactName,PhoneNumber,Email,ImagePath,Nickname,BirthDay,Address,Notes")] ContactItem contactItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactItem);
        }

        // GET: ContactItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactItem = await _context.ContactItems.FindAsync(id);
            if (contactItem == null)
            {
                return NotFound();
            }
            return View(contactItem);
        }

        // POST: ContactItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContactName,PhoneNumber,Email,ImagePath,Nickname,BirthDay,Address,Notes")] ContactItem contactItem)
        {
            if (id != contactItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactItemExists(contactItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactItem);
        }

        // GET: ContactItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactItem = await _context.ContactItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactItem == null)
            {
                return NotFound();
            }

            return View(contactItem);
        }

        // POST: ContactItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactItem = await _context.ContactItems.FindAsync(id);
            if (contactItem != null)
            {
                _context.ContactItems.Remove(contactItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactItemExists(int id)
        {
            return _context.ContactItems.Any(e => e.Id == id);
        }
    }
}
