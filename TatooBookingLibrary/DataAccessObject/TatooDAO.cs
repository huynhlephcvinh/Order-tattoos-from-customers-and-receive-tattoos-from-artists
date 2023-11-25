using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class TatooDAO
    {
        public TatooDAO() { }

        public void AddTattooDAO(Tatoo tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.Tatoos.Add(tattoo);
                context.SaveChanges();
            }
        }

        public List<Tatoo> GetTatoosDAO()
        {
            List<Tatoo> list = new List<Tatoo>();
            using (var context = new TatooBookingContext())
            {
                list= context.Tatoos.ToList();
            }
            return list;
        }

        public void UpdateTatooDAO(Tatoo tattoo)
        {
            using (var context = new TatooBookingContext())
            {
                context.Tatoos.Update(tattoo);
                context.SaveChanges();
            }
        }

        public void DeleteTatooDAO(int id)
        {
            using (var context = new TatooBookingContext())
            {
                Tatoo tatoo = context.Tatoos.FirstOrDefault(t => t.Id == id);
                context.Tatoos.Remove(tatoo);
                context.SaveChanges();
            }
        }
    }
}
