using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IBookingTatooRepository
    {
        public List<BookingTatoo> GetBookingTatoos();
        public void UpdateBookingTatoo(BookingTatoo bookingTatoo);
        public void CreateBookingTatoo(BookingTatoo bookingTatoo);
    }
}
