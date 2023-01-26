using System.ComponentModel.DataAnnotations;

namespace MvcHotelRecords.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

        public string CreditCardNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        
        
    }
}