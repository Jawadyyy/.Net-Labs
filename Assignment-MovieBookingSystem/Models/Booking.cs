using System.ComponentModel.DataAnnotations;

namespace MovieBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Movie title is required")]
        public string MovieTitle { get; set; }

        [Required(ErrorMessage = "Customer name is required")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Showtime is required")]
        public DateTime Showtime { get; set; }

        [Required(ErrorMessage = "Seat number is required")]
        public string SeatNumber { get; set; }
    }
}
