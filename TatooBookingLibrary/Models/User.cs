using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class User
    {
        public User()
        {
            BookingServices = new HashSet<BookingService>();
            BookingTatoos = new HashSet<BookingTatoo>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? Role { get; set; }
        public byte? Status { get; set; }

        public virtual ICollection<BookingService> BookingServices { get; set; }
        public virtual ICollection<BookingTatoo> BookingTatoos { get; set; }
    }
}
