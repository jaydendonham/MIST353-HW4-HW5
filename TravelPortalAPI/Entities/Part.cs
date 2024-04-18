using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Part
    {
        [Key]
        public int PNum { get; set; }
        public string PManu { get; set; }
        public string PCategory { get; set; }
        public string PCountry { get; set; }
        public int? PPrice { get; set; }
        public string PDescription { get; set; }
    }
}
