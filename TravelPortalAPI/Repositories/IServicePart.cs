//Ryan Sladic
using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    public interface IServiceParts
    {
        Task<List<Part>> GetPartDetails(int PNum, string PManu, string PCategory, string PCountry, int? price, string PDescription);
    }
}
