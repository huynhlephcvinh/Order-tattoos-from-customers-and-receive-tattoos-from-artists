using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class DateWorkForArtistDAO
    {
        public DateWorkForArtistDAO()
        {
        }

        public List<DateWorkForArtist> GetDateWorkForArtistsDAO()
        {
            List<DateWorkForArtist> list = new List<DateWorkForArtist>();
            using (var context = new TatooBookingContext())
            {
                list = context.DateWorkForArtists.ToList();
            }
            return list;
        }

        public void AddDateWorkForArtistDAO(DateWorkForArtist dateWorkForArtist)
        {
            using (var context = new TatooBookingContext())
            {
                context.DateWorkForArtists.Add(dateWorkForArtist);
                context.SaveChanges();
            }
        }

        public void UpdateDateWorkForArtistDAO(DateWorkForArtist dateWorkForArtist)
        {
            using (var context = new TatooBookingContext())
            {
                context.DateWorkForArtists.Update(dateWorkForArtist);
                context.SaveChanges();
            }
        }

        public void DeleteDateWorkForArtistDAO(int id)
        {
            using (var context = new TatooBookingContext())
            {
                DateWorkForArtist tatoo = context.DateWorkForArtists.FirstOrDefault(t => t.Id == id);
                context.DateWorkForArtists.Remove(tatoo);
                context.SaveChanges();
            }
        }
    }
}
