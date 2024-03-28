using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Location
    {
        public int LID { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(20)]
        public string Zipcode { get; set; }
    }
}
