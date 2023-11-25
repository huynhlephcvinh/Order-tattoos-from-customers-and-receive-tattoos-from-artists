using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IStudioRepository
    {
        public List<Studio> GetStudios();
        public Studio GetStudio(int? id);
        void SaveStudio(Studio studio);
        void DeleteStudio(Studio studio);
        void UpdateStudio(Studio studio);
        List<Studio> GetAllStudios();
        Studio GetStudioById(int id);
    }
}
