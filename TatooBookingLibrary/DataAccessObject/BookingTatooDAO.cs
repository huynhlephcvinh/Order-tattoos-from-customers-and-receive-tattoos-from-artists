using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class BookingTatooDAO
    {
        public BookingTatooDAO() { }

        public List<BookingTatoo> GetBookingTatoosDAO()
        {
            List<BookingTatoo> list = new List<BookingTatoo>();
            using (var context = new TatooBookingContext())
            {
                list = context.BookingTatoos.ToList();
            }
            return list;
        }
        public void UpdateBookingTatooDAO(BookingTatoo tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.BookingTatoos.Update(tattoo);
                context.SaveChanges();
            }

        }

        public void CreateBookingTatooDAO(BookingTatoo tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.BookingTatoos.Add(tattoo);
                context.SaveChanges();
            }
        }


    }
}
