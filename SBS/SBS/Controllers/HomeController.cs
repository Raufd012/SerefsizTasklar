using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBS.DAL;
using SBS.Models;
using System.Diagnostics;

namespace SBS.Controllers
{
    public class HomeController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories.Select(s=> new Category
            {
                Description = s.Description,
                Id = s.Id,
                Image=s.Image,
                Name= s.Name
            }).ToListAsync();
            return View(data);
        }
    }
}
