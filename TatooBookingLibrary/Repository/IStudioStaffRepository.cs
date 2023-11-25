using System;
using System.Collections.Generic;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    internal interface IStudioStaffRepository
    {
        void SaveStudioStaff(StudioStaff studiostaff);
        void Delete(StudioStaff studioStaff);
        void Update(StudioStaff studioStaff);
        List<StudioStaff> GetAllStudioStaffs();
        StudioStaff GetStudioStaffById(int id);
        StudioStaff? CheckLogin(string username, string password);
        List<StudioStaff> GetStafftByName(string findName);
    }
}
