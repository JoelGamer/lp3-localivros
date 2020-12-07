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
    class TableBooks : Connection
    {
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            string command = "SELECT * FROM book";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Book book = new Book(sqlDataReader.GetInt32(0));
                    book.SetName(sqlDataReader.GetString(1));
                    book.SetDescripton(sqlDataReader.GetString(2));
                    book.SetAuthor(new Author(sqlDataReader.GetInt32(3)));
                    book.SetPages(sqlDataReader.GetInt32(4));
                    book.SetGenre(new Genre(sqlDataReader.GetInt32(5)));
                    book.SetReleaseDate(sqlDataReader.GetDateTime(6));
                    book.SetPrice(sqlDataReader.GetDouble(7));
                    books.Add(book);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return books;
        }
    }
}
