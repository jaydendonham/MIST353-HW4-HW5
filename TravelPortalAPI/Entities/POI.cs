using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelPortalAPI.Entities
{
    public class Driver
    {
	public int POI { get; set; }

	[Required]
	public string POI_Name { get; set; }

	[Required]
	public int POI_Add_Num { get; set; }

	[Required]
	public string POI_Street { get; set; }
	
	[Required]
	public string POI_City { get; set; }
	
	[Required]
	public string POI_State{ get; set; }

	[Required]
	public int POI_ZIP{ get; set; }
    }
}
