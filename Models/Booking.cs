using System;

namespace VBdemo.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int EmployeeId { get; set; }
    }
}