using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Occupation
    {
        [Key]
        public int OID { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public double Wage { get; set; }
    }
}
