using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;

        public HomeController(EternaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Sliders  = _context.Sliders.OrderBy(x=>x.Order).ToList(),
                Features = _context.Features.ToList()
            };

            return View(vm);
        }
    }
}