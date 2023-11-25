using System;
using System.Collections.Generic;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class StudioStaffRepository : IStudioStaffRepository
    {
        public StudioStaff CheckLogin(string username, string password)
        => StudioStaffDAO.CheckLogin(username, password);

        public void Delete(StudioStaff studioStaff)
        => StudioStaffDAO.DeleteStudioStaff(studioStaff);

        public List<StudioStaff> GetAllStudioStaffs()
        => StudioStaffDAO.GetAllStudioStaff();

        public List<StudioStaff> GetStafftByName(string findName)
        => StudioStaffDAO.GetArtistByName(findName);

        public StudioStaff GetStudioStaffById(int id)
        => StudioStaffDAO.GetStudioStaffById(id);

        public void SaveStudioStaff(StudioStaff studiostaff)
        => StudioStaffDAO.SaveStudioStaff(studiostaff);

        public void Update(StudioStaff studioStaff)
        => StudioStaffDAO.UpdateStudioStaff(studioStaff);
    }
}
