using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int NumberOfSeats { get; set; }

        public int EventId { get; set; }

        public Evnts Event { get; set; } = null!;
    }
}
