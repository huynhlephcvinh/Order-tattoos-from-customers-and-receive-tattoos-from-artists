using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class StudioStaff
    {
        public int? Id { get; set; }
        public int? StudioId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public byte? Status { get; set; }

        public virtual Studio Studio { get; set; }
    }
}
