using System;
using System.Collections.Generic;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IArtistRepository
    {
        public List<Artist> GetArtists();
        public void UpdateArtist(Artist artist);
        public Artist GetArtist(int id);
        void SaveArtist(Artist artist);
        void DeleteArtist(Artist artist);
        void Updateartist(Artist artist);
        List<Artist> GetAllArtists();
        List<Artist> GetAllArtistsByStudioID(int id);
        Artist GetArtistByEmail(String email);
        Artist GetArtistById(int id);
        List<Artist> GetArtistByName(string findName);
        Artist? CheckLogin(string username, string password);
    }
}
