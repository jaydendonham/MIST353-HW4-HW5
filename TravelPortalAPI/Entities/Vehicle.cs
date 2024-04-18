using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Vehicle
    {
        [Key]
        public int VIN { get; set; }
        public string VMake { get; set; }
        public string VModel { get; set; }
        public int? VYear { get; set; }
    }
}
