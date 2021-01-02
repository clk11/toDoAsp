using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly toDoContext _context;

        public HomeController(toDoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //Delete all purpose
            // foreach (var item in _context.toDoItems)
            // {
            //     _context.Remove(item);
            //     await _context.SaveChangesAsync();
            // }
            return View(await _context.toDoItems.ToListAsync());
        }
        public async Task<IActionResult> Remove([Bind("ID")] int id){
            
            _context.toDoItems.Remove(_context.toDoItems.FirstOrDefault(x=>x.ID == id));
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Add([Bind("ID,Name")] Item item)
        {
            item.data = DateTime.Now;
            _context.toDoItems.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}