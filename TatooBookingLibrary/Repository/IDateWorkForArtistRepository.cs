using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IDateWorkForArtistRepository
    {
        public List<DateWorkForArtist> GetDateWorkForArtists();
        public void AddDateWorkForArtist(DateWorkForArtist dateWorkForArtist);
        public void UpdateDateWorkForArtist(DateWorkForArtist dateWorkForArtist);
        public void DeleteDateWorkForArtist(int id);
    }
}
