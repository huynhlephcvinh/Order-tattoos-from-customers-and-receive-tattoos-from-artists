using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class TatooCategoryDAO
    {
        public TatooCategoryDAO() { }

        public List<TatooCategory> GetTatooCategoriesDAO()
        {
            List<TatooCategory> list = new List<TatooCategory>();
            using (var context = new TatooBookingContext())
            {
                list = context.TatooCategories.ToList();
            }
            return list;
        }

        public TatooCategory GetTatooCategoryDAO(int id)
        {
            TatooCategory category = new TatooCategory();
            using (var context = new TatooBookingContext())
            {
                category = context.TatooCategories.FirstOrDefault(x => x.Id == id); ;
            }
            return category;
        }
    }
}
