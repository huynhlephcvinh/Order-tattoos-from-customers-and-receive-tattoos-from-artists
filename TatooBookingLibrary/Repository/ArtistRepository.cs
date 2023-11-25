using System;
using System.Collections.Generic;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        public ArtistDAO artistDAO = new ArtistDAO();

        public List<Artist> GetArtists() => artistDAO.GetArtistsDAO();

        public void UpdateArtist(Artist artist) => artistDAO.UpdateArtistDAO(artist);
        public Artist GetArtist(int id) => artistDAO.GetArtistDAO(id);

        public Artist CheckLogin(string username, string password)
        => ArtistDAO.CheckLogin(username, password);

        public void DeleteArtist(Artist artist)
        => ArtistDAO.DeleteArtist(artist);

        public List<Artist> GetAllArtists()
        => ArtistDAO.GetAllArtist();

        public List<Artist> GetAllArtistsByStudioID(int id)
        => ArtistDAO.GetAllArtistBySudioID(id);

        public Artist GetArtistByEmail(string email)
        => ArtistDAO.GetArtistByEmail(email);

        public Artist GetArtistById(int id)
        => ArtistDAO.GetArtistById(id);

        public void SaveArtist(Artist artist)
        => ArtistDAO.SaveArtist(artist);

        public void Updateartist(Artist artist)
        => ArtistDAO.UpdateArtist(artist);

        List<Artist> IArtistRepository.GetArtistByName(string findName)
        => ArtistDAO.GetArtistByName(findName);
    }
}
