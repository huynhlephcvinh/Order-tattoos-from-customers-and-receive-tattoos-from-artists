using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IBookingServiceRepository
    {
        public List<BookingService> GetBookingServices();
        public void CreateBookingService(BookingService bookingService);
        public void UpdateBookingService(BookingService bookingService);
    }
}
