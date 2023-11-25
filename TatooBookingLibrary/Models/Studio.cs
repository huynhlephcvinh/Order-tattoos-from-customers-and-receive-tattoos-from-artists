using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class Studio
    {
        public Studio()
        {
            Artists = new HashSet<Artist>();
            StudioStaffs = new HashSet<StudioStaff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Status { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<StudioStaff> StudioStaffs { get; set; }
    }
}
