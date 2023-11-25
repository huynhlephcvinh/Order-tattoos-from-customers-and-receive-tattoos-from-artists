using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface ITatooCategoryRepository
    {
        public List<TatooCategory> GetTatooCategories();


        public TatooCategory GetTatooCategory(int id);
    }
}
