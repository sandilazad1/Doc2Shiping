using System.ComponentModel.DataAnnotations.Schema;

namespace Doc2Shiping.Data
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }

        public float HotelRent { get; set; }

        [ForeignKey(nameof(Country))]

        public int CountryId { get; set; }
        public Country Country { get; set; }


    }
}
