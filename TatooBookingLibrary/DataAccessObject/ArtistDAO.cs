using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class ArtistDAO
    {
        public ArtistDAO() { }

        public List<Artist> GetArtistsDAO()
        {
            List<Artist> list = new List<Artist>();
            using (var context = new TatooBookingContext())
            {
                list = context.Artists.ToList();
            }
            return list;
        }
        public Artist GetArtistDAO(int id)
        {
            Artist artist = new Artist();
            using (var context = new TatooBookingContext())
            {
                artist = context.Artists.SingleOrDefault(x => x.Id == id);
            }
            return artist;
        }
        public void UpdateArtistDAO(Artist artist)
        {
            using (var context = new TatooBookingContext())
            {
                context.Artists.Update(artist);
                context.SaveChanges();
            }
        }
        public static List<Artist> GetAllArtist()
        {
            List<Artist> listArtists = new List<Artist>();
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var artistcontext = new TatooBookingContext())
                {
                    listArtists = artistcontext.Artists.ToList();
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var artist in listArtists)
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listArtists;
        }

        public static List<Artist> GetAllArtistBySudioID(int id)
        {
            List<Artist> listArtists = new List<Artist>();
            List<Artist> result = new List<Artist>();
            List<Studio> listStudios = new List<Studio>();
            try
            {
                using (var artistcontext = new TatooBookingContext())
                {
                    listArtists = artistcontext.Artists.ToList();
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var artist in listArtists)
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
                foreach (var artist in listArtists)
                {
                    if (artist.StudioId == id)
                    {
                        result.Add(artist);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static Artist GetArtistById(int id)
        {
            Artist artist = new Artist();
            List<Artist> listArtist = new List<Artist>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.Artists.SingleOrDefault(m => m.Id == id);
                    artist = p1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return artist;
        }

        public static Artist GetArtistByEmail(string email)
        {
            Artist artist = new Artist();
            List<Artist> listArtist = new List<Artist>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.Artists.SingleOrDefault(m => m.Email == email);
                    artist = p1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return artist;
        }

        public static List<Artist> GetArtistByName(string findName)
        {
            List<Artist> listArtist = new List<Artist>();
            List<Studio> listStudios = new List<Studio>();
            List<Artist> listFindArtist = new List<Artist>();

            try
            {
                using (var artistcontext = new TatooBookingContext())
                {
                    listArtist = artistcontext.Artists.ToList();
                }
                using (var studiocontext = new TatooBookingContext())
                {
                    listStudios = studiocontext.Studios.ToList();
                }
                foreach (var artist in listArtist)
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
                foreach (var item in listArtist)
                {
                    if (item.Name.Contains(findName))
                    {
                        listFindArtist.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listFindArtist;
        }
        public static Artist? CheckLogin(string email, string password)
        {
            Artist artist = new Artist();
            List<Artist> listArtist = new List<Artist>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    ;
                    listArtist = context.Artists.ToList();
                    foreach (var action in listArtist)
                    {
                        if (action.Email == email && action.Password == password)
                        {
                            artist = action;
                            return artist;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return null;
        }

        public static void SaveArtist(Artist artist)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Artists.Add(artist);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteArtist(Artist artist)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    var p1 = context.Artists.SingleOrDefault(m => m.Id == artist.Id);
                    context.Artists.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateArtist(Artist artist)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Entry<Artist>(artist).State = EntityState.Modified;
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
