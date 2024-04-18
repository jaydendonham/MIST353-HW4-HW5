using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Driver
    {
		[Key]
		public int DID { get; set; }

		[Required]
		public string DPosition { get; set; }

		[Required]
		public string D_First { get; set; }

		[Required]
		public string D_Last { get; set; }
	
		[Required]
		public string D_Hometown { get; set; }
	
		[Required]
		public string D_LNum { get; set; }
    }
}
