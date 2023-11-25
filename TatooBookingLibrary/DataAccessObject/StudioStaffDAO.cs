using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class StudioStaffDAO
    {
        public static List<StudioStaff> GetAllStudioStaff()
        {
            List<StudioStaff> listStudioStaffs = new List<StudioStaff>();
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var artistcontext = new TatooBookingContext())
                {
                    listStudioStaffs = artistcontext.StudioStaffs.ToList();
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var staffs in listStudioStaffs)
                {
                    foreach (var studio in listStudios)
                    {
                        if (staffs.StudioId == studio.Id)
                        {
                            staffs.Studio = studio;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listStudioStaffs;

        }
        public static StudioStaff GetStudioStaffById(int id)
        {
            StudioStaff studioStaff = new StudioStaff();
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.StudioStaffs.SingleOrDefault(m => m.Id == id);
                    studioStaff = p1;
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var studio in listStudios)
                {
                    if (studioStaff.StudioId == studio.Id)
                    {
                        studioStaff.Studio = studio;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studioStaff;
        }

        public static StudioStaff? CheckLogin(string email, string password)
        {
            StudioStaff studioStaff = new StudioStaff();
            List<StudioStaff> listStudioStaff = new List<StudioStaff>();
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    listStudioStaff = context.StudioStaffs.ToList();
                    foreach (var action in listStudioStaff)
                    {
                        if (action.Email == email && action.Password == password)
                        {
                            studioStaff = action;
                            break;
                        }
                    }
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var studio in listStudios)
                {
                    if (studioStaff.StudioId == studio.Id)
                    {
                        studioStaff.Studio = studio;
                        return studioStaff;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static void SaveStudioStaff(StudioStaff studioStaff)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.StudioStaffs.Add(studioStaff);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteStudioStaff(StudioStaff studioStaff)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.StudioStaffs.SingleOrDefault(m => m.Id == studioStaff.Id);
                    context.StudioStaffs.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateStudioStaff(StudioStaff studioStaff)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Entry<StudioStaff>(studioStaff).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<StudioStaff> GetArtistByName(string findName)
        {
            List<StudioStaff> listStaff = new List<StudioStaff>();
            List<Studio> listStudios = new List<Studio>();
            List<StudioStaff> listFindStaff = new List<StudioStaff>();

            try
            {
                using (var artistcontext = new TatooBookingContext())
                {
                    listStaff = artistcontext.StudioStaffs.ToList();
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var artist in listStaff)
                {
                    foreach (var studio in listStudios)
                    {
                        if (artist.StudioId == studio.Id)
                        {
                            artist.Studio = studio;
                            break;
                        }
                    }
                }
                foreach (var item in listStaff)
                {
                    if (item.Name.Contains(findName))
                    {
                        listFindStaff.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listFindStaff;
        }
    }
}
