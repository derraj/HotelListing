using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        // a Dto should never have a field that is directly related to a data model
        // a Dto shoul only talk to another Dto
        public List<HotelDto> Hotels { get; set; }
    }
}
