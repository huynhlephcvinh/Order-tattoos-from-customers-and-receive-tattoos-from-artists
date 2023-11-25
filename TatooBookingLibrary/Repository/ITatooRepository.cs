using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface ITatooRepository
    {
        public void CreateTatoo(Tatoo tatoo);
        public List<Tatoo> GetTatoos();
        public void UpdateTatoo(Tatoo tatoo);
        public void DeleteTatoo(int id);
    }
}
