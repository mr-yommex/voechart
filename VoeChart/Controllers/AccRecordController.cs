using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using VoeChart.DataLayer;
using VoeChart.Models;

namespace VoeChart.Controllers
{
    public class AccRecordController : Controller
    {
        private readonly DbContextAccomodation _context;

        public AccRecordController(DbContextAccomodation context)
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

            List<string> labels=_context.accomodation.Select(p => p.Month).ToList();
            data.Add(labels);

            List<int> Rooms = _context.accomodation.Select(p => p.Rooms_per_month).ToList();
            data.Add(Rooms);

             return data;
        }

    }
}
