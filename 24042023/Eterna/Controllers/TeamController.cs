using Eterna.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        private readonly EternaDbContext _context;

        public TeamController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.TeamMembers.Include(x => x.Position).ToList();
            return View(data);
        }
    }
}
