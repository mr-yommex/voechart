using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using PersonnelChart.DataLayer;
using PersonnelChart.Models;

namespace PersonnelChart.Controllers
{
    public class AccRecordController : Controller
    {
        private readonly DbContextPersonnel _context;

        public AccRecordController(DbContextPersonnel context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAccData()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetAccData()
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
