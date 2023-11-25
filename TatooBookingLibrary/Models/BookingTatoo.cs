using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class BookingTatoo
    {
        public int Id { get; set; }
        public int? UsersId { get; set; }
        public int? ArtistId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UsersPhone { get; set; }
        public DateTime? UsersBookDate { get; set; }
        public TimeSpan? UsersBookTime { get; set; }
        public byte? Status { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual User Users { get; set; }
    }
}
