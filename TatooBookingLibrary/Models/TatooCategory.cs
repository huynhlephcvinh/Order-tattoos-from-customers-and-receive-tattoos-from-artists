using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class TatooCategory
    {
        public TatooCategory()
        {
            Tatoos = new HashSet<Tatoo>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Tatoo> Tatoos { get; set; }
    }
}
