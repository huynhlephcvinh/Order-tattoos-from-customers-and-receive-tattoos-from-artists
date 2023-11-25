using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class BookingServiceDAO
    {
        public BookingServiceDAO() { }

        public List<BookingService> GetBookingServicesDAO()
        {
            List<BookingService> list = new List<BookingService>();
            using (var context = new TatooBookingContext())
            {
                list = context.BookingServices.ToList();
            }
            return list;
        }

        public void AddBookingServiceDAO(BookingService tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.BookingServices.Add(tattoo);
                context.SaveChanges();
            }
        }

        public void UpdateBookingServiceDAO(BookingService tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.BookingServices.Update(tattoo);
                context.SaveChanges();
            }
        }


    }
}
