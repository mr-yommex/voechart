using System.ComponentModel.DataAnnotations;

namespace PersonnelChart.Models
{
    public class PerEntity
    {
        [Key]
        public int Id { get; set; }
        public string category { get; set; }
        public int No_of_users { get; set; }
    }
}

