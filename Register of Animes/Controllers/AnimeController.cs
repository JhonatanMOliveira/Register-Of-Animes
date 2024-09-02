using System.Data;
using Register_of_Animes.Data;
using Register_of_Animes.Models;

namespace Register_of_Animes.Controllers
{
    public class AnimeController
    {
        public void InitializeDatabase()
        {
            DALRegister.CreateDataSQLite();
            DALRegister.CreateTableSQLite();
        }

        public string GetDatabasePath()
        {
            return DALRegister.path;
        }

        public DataTable GetAnimes()
        {
            return DALRegister.GetAnimes();
        }

        public DataTable GetAnimesByName(string name)
        {
            return DALRegister.GetAnimes(name);
        }

        public DataTable GetAnimeById(int id)
        {
            return DALRegister.GetAnime(id);
        }

        public void AddAnime(Anime anime)
        {
            DALRegister.Add(anime);
        }

        public void UpdateAnime(Anime anime)
        {
            DALRegister.Update(anime);
        }

        public void DeleteAnime(int id)
        {
            DALRegister.Delete(id);
        }
    }
}
