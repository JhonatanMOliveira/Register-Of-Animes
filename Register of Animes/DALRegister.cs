using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Register_of_Animes
{
    public class DALRegister
    {
        public static string path = Directory.GetCurrentDirectory() + "\\register.sqlite";
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CreateDataSQLite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }
        }

        public static void CreateTableSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Animes(id int, name Varchar(100), gender Varchar(50), episode Varchar(50))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAnimes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Animes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAnimes(string name)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Animes where name like '%" + name + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAnime(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Animes Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(Anime anime)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Animes(id, name, gender, episode) values (@id, @name, @gender, @episode)";
                    cmd.Parameters.AddWithValue("@id", anime.Id);
                    cmd.Parameters.AddWithValue("@name", anime.Name);
                    cmd.Parameters.AddWithValue("@gender", anime.Gender);
                    cmd.Parameters.AddWithValue("@episode", anime.Episode);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Anime anime)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Animes SET Name=@Name, Gender=@Gender, Episode=@Episode WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", anime.Id);
                    cmd.Parameters.AddWithValue("@Name", anime.Name);
                    cmd.Parameters.AddWithValue("@Gender", anime.Gender);
                    cmd.Parameters.AddWithValue("@Episode", anime.Episode);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Animes Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
