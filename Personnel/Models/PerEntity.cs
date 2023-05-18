using System.ComponentModel.DataAnnotations;

namespace Personnel.Models
{
    public class PerEntity
    {
        [Key]
        public int id { get; set; }
        public string category { get; set; }
        public int No_of_users { get; set; }
    }
}
