using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class StudioDAO
    {
        public StudioDAO() { }

        public List<Studio> GetStudiosDAO()
        {
            List<Studio> list = new List<Studio>();
            using (var context = new TatooBookingContext())
            {
                list = context.Studios.ToList();
            }
            return list;
        }

        public Studio GetStudioDAO(int? id)
        {
            Studio user = new Studio();
            using (var context = new TatooBookingContext())
            {
                user = context.Studios.SingleOrDefault(x => x.Id == id);
            }
            return user;
        }
        public static List<Studio> GetAllStudio()
        {
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listStudios;
        }
        public static Studio GetStudioById(int id)
        {
            Studio studio = new Studio();
            List<Studio> listStudio = new List<Studio>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.Studios.SingleOrDefault(m => m.Id == id);
                    studio = p1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studio;
        }

        public static void SaveStudio(Studio studio)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Studios.Add(studio);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteStudio(Studio studio)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.Studios.SingleOrDefault(m => m.Id == studio.Id);
                    context.Studios.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateStudio(Studio studio)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Entry<Studio>(studio).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
