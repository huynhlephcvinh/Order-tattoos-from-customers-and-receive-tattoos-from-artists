using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class Tatoo
    {
        public Tatoo()
        {
            BookingServices = new HashSet<BookingService>();
        }

        public int Id { get; set; }
        public string TatooName { get; set; }
        public string TatooDescription { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public byte[] Img { get; set; }
        public byte? Status { get; set; }

        public virtual TatooCategory Category { get; set; }
        public virtual ICollection<BookingService> BookingServices { get; set; }
    }
}
