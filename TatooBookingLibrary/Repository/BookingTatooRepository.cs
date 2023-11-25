using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class BookingTatooRepository : IBookingTatooRepository
    {
        public BookingTatooDAO BookingTatooDAO = new BookingTatooDAO();
        
        public List<BookingTatoo> GetBookingTatoos() => BookingTatooDAO.GetBookingTatoosDAO();
        public void UpdateBookingTatoo(BookingTatoo bookingTatoo) => BookingTatooDAO.UpdateBookingTatooDAO(bookingTatoo);
        public void CreateBookingTatoo(BookingTatoo bookingTatoo) => BookingTatooDAO.CreateBookingTatooDAO(bookingTatoo);
    }
}
