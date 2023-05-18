using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using Inventory.DataLayer;
using Inventory.Models;

namespace Inventory.Controllers
{
    public class InvRecordController : Controller
    {
        private readonly DbContextInventory _context;

        public InvRecordController(DbContextInventory context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowInvData()
        {
            return View();
        }

        [HttpPost] 
        public List<object> GetInvData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.inventory.Select(p => p.section).ToList();
            data.Add(labels);

            List<int> Rooms = _context.inventory.Select(p => p.available_items).ToList();
            data.Add(Rooms);

            return data;
        }

    }
}
