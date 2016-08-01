using System;
using System.Collections.Generic;

namespace VBdemo.Models
{
    public class Employee 
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}