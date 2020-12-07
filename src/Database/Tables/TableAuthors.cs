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
    class TableAuthors : Connection
    {
        public List<Author> GetAll()
        {
            List<Author> authors = new List<Author>();
            string command = "SELECT * FROM author";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Author author = new Author(sqlDataReader.GetInt32(0));
                    author.SetName(sqlDataReader.GetString(1));
                    author.SetBirthDate(sqlDataReader.GetDateTime(2));
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        author.SetDeathDate(sqlDataReader.GetDateTime(3));
                    }

                    authors.Add(author);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return authors;
        }

        public Author GetAuthor(int uid)
        {
            Author author = new Author(uid);
            string command = "SELECT * FROM author WHERE uid=" + uid.ToString();

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                author.SetName(sqlDataReader.GetString(1));
                author.SetBirthDate(sqlDataReader.GetDateTime(2));
                if (!sqlDataReader.IsDBNull(3))
                {
                    author.SetDeathDate(sqlDataReader.GetDateTime(3));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return author;
        }

        public void CreateAuthor(Author author)
        {
            string command = "INSERT INTO AUTHOR(name, birth_date, death_date) " +
                "VALUES('" + author.GetName() + "', " + FormatDateTimeToSQLDate(author.GetBirthDate()) + ", " + FormatDateTimeToSQLDate(author.GetDeathDate()) + ")";
            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void UpdateAuthor(int uid, Author author)
        {
            string command = "UPDATE AUTHOR SET " +
                "name='" + author.GetName() + "', " +
                "birth_date=" + FormatDateTimeToSQLDate(author.GetBirthDate()) + ", " +
                "death_date=" + FormatDateTimeToSQLDate(author.GetDeathDate()) + " " +
                "WHERE uid=" + uid.ToString();

            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void DeleteAuthor(Author author)
        {
            string command = "DELETE FROM author WHERE uid=" + author.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
