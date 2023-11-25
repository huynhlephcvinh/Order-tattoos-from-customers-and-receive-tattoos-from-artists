using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class StudioRepository : IStudioRepository
    {
        public StudioDAO studioDAO = new StudioDAO();

        public List<Studio> GetStudios() => studioDAO.GetStudiosDAO();

        public Studio GetStudio(int? id) => studioDAO.GetStudioDAO(id);
        public void DeleteStudio(Studio studio)
        => StudioDAO.DeleteStudio(studio);

        public List<Studio> GetAllStudios()
        => StudioDAO.GetAllStudio();

        public Studio GetStudioById(int id)
        => StudioDAO.GetStudioById(id);

        public void SaveStudio(Studio studio)
        => StudioDAO.SaveStudio(studio);

        public void UpdateStudio(Studio studio)
        => StudioDAO.UpdateStudio(studio);
    }
}
