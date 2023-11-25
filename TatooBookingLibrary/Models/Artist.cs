using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class Artist
    {
        public Artist()
        {
            BookingServices = new HashSet<BookingService>();
            BookingTatoos = new HashSet<BookingTatoo>();
            DateWorkForArtists = new HashSet<DateWorkForArtist>();
        }

        public int? Id { get; set; }
        public int? StudioId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual Studio Studio { get; set; }
        public virtual ICollection<BookingService> BookingServices { get; set; }
        public virtual ICollection<BookingTatoo> BookingTatoos { get; set; }
        public virtual ICollection<DateWorkForArtist> DateWorkForArtists { get; set; }
    }
}
