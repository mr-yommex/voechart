using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class InvEntity
    {
        [Key]
        public int id { get; set; }
        public string section { get; set; }
        public int available_items { get; set; }
    }
}
