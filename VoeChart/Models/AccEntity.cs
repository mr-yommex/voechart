using System.ComponentModel.DataAnnotations;

namespace VoeChart.Models
{
    public class AccEntity
    {
        [Key]
        public int Id { get; set; }
        public string Month { get; set; }
        public int Rooms_per_month { get; set; }
    }
}
