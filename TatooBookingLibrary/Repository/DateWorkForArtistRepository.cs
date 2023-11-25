using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class DateWorkForArtistRepository : IDateWorkForArtistRepository
    {
        public DateWorkForArtistDAO dateWorkForArtistDAO = new DateWorkForArtistDAO();
        public List<DateWorkForArtist> GetDateWorkForArtists() => dateWorkForArtistDAO.GetDateWorkForArtistsDAO();
        public void AddDateWorkForArtist(DateWorkForArtist dateWorkForArtist) => dateWorkForArtistDAO.AddDateWorkForArtistDAO(dateWorkForArtist);
        public void UpdateDateWorkForArtist(DateWorkForArtist dateWorkForArtist) => dateWorkForArtistDAO.UpdateDateWorkForArtistDAO(dateWorkForArtist);
        public void DeleteDateWorkForArtist(int id) => dateWorkForArtistDAO.DeleteDateWorkForArtistDAO(id);
    }
}
