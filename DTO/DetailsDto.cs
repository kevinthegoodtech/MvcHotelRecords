using System.ComponentModel.DataAnnotations;

namespace MvcHotelRecords.Models
{
    public class DetailsDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        


        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
