using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class BookingService
    {
        public int Id { get; set; }
        public int? UsersId { get; set; }
        public int? ArtistId { get; set; }
        public int? TatooId { get; set; }
        public DateTime InkDay1 { get; set; }
        public DateTime? InkDay2 { get; set; }
        public DateTime? InkDay3 { get; set; }
        public decimal? TotalPrice { get; set; }
        public byte? Status { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Tatoo Tatoo { get; set; }
        public virtual User Users { get; set; }
    }
}
