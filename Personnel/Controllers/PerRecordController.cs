using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using Personnel.DataLayer;
using Personnel.Models;

namespace Personnel.Controllers
{
    public class PerRecordController : Controller
    {
        private readonly DbContextPersonnel _context;

        public PerRecordController(DbContextPersonnel context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowPerData()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetPerData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.personnel.Select(p => p.category).ToList();
            data.Add(labels);

            List<int> Rooms = _context.personnel.Select(p => p.No_of_users).ToList();
            data.Add(Rooms);

            return data;
        }

    }
}
