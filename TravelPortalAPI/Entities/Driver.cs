using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Driver
    {
	public int DID { get; set; }
	public string DPosition { get; set; }
	public string D_First { get; set; }
	public string D_Last { get; set; }
	public string D_Hometown { get; set; }
	public string D_LNum { get; set; }
    }
}
