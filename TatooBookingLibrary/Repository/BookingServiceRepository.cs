using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class BookingServiceRepository : IBookingServiceRepository
    {
        public BookingServiceDAO bookingServiceDAO = new BookingServiceDAO();

        public List<BookingService> GetBookingServices() => bookingServiceDAO.GetBookingServicesDAO();

        public void CreateBookingService(BookingService bookingService) => bookingServiceDAO.AddBookingServiceDAO(bookingService);

        public void UpdateBookingService(BookingService bookingService) => bookingServiceDAO.UpdateBookingServiceDAO(bookingService);
    }
}
