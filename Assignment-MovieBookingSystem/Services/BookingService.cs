// BookingService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using MovieBookingSystem.Models;

namespace MovieBookingSystem.Services
{
    public class BookingService
    {
        private List<Booking> _bookings = new List<Booking>();
        private int _nextId = 1;

        public IEnumerable<Booking> GetAllBookings()
        {
            return _bookings;
        }

        public Booking? GetBookingById(int id)
        {
            return _bookings.FirstOrDefault(b => b.Id == id);
        }

        public void AddBooking(Booking booking)
        {
            booking.Id = _nextId++;
            _bookings.Add(booking);
        }

        public bool UpdateBooking(Booking booking)
        {
            var existing = _bookings.FirstOrDefault(b => b.Id == booking.Id);
            if (existing != null)
            {
                existing.MovieTitle = booking.MovieTitle;
                existing.CustomerName = booking.CustomerName;
                existing.Showtime = booking.Showtime;
                existing.SeatNumber = booking.SeatNumber;
                return true;
            }
            return false;
        }

        public bool DeleteBooking(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
            {
                return _bookings.Remove(booking);
            }
            return false;
        }
    }
}