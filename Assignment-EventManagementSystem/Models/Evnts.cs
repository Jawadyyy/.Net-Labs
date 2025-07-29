using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Evnts
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        [Required]
        public DateTime EventDateTime { get; set; }

        [Required]
        public string Venue { get; set; } = string.Empty;

        [Required]
        public decimal TicketPrice { get; set; }

        [Required]
        public int MaximumSeats { get; set; }

        public ICollection<Bookings> Booking { get; set; } = new List<Bookings>();
    }
}
