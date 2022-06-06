using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    //prevent overposting and overexposing data
    // must have same name as Model
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
