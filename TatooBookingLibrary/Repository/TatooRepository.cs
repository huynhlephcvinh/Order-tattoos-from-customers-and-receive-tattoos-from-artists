using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class TatooRepository : ITatooRepository
    {
        public TatooDAO tatooDAO =new TatooDAO();

        public void CreateTatoo(Tatoo tatoo)
        {
            tatooDAO.AddTattooDAO(tatoo);
        }
        public void UpdateTatoo(Tatoo tatoo)
        {
            tatooDAO.UpdateTatooDAO(tatoo);
        }
        public List<Tatoo> GetTatoos()
        {
            return tatooDAO.GetTatoosDAO();
        }

        public void DeleteTatoo(int id)
        {
            tatooDAO.DeleteTatooDAO(id);
        }
    }
}
