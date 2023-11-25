using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class TatooCategoryRepository : ITatooCategoryRepository
    {
        public TatooCategoryDAO tatooCategoryDAO = new TatooCategoryDAO();

        public List<TatooCategory> GetTatooCategories()
        {
            return tatooCategoryDAO.GetTatooCategoriesDAO();
        }

        public TatooCategory GetTatooCategory(int id)
        {
            return tatooCategoryDAO.GetTatooCategoryDAO(id);
        }
    }
}
