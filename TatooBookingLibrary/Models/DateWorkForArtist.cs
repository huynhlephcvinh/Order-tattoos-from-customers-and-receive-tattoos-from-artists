using System;
using System.Collections.Generic;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class DateWorkForArtist
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public DateTime? WorkDate { get; set; }
        public TimeSpan? StartWorkHour { get; set; }
        public TimeSpan? EndWorkHour { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
