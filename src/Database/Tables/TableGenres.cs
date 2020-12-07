using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Database.Tables
{
    class TableGenres : Connection
    {
        public List<Genre> GetAll()
        {
            List<Genre> genres = new List<Genre>();
            string command = "SELECT * FROM genre";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Genre genre = new Genre(sqlDataReader.GetInt32(0));
                    genre.SetName(sqlDataReader.GetString(1));
                    genres.Add(genre);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return genres;
        }

        public void CreateGenre(Genre genre)
        {
            string command = "INSERT INTO GENRE(name) VALUES('" + genre.GetName() + "')";
            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void UpdateGenre(int uid, Genre genre)
        {
            string command = "UPDATE GENRE SET " +
                "name='" + genre.GetName() + "' " +
                "WHERE uid=" + uid.ToString();

            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void DeleteGenre(Genre genre)
        {
            string command = "DELETE FROM genre WHERE uid=" + genre.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
