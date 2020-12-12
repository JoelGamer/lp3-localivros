using System.Collections.Generic;
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
                    book.SetAuthor(new TableAuthors().GetAuthor(sqlDataReader.GetInt32(3)));
                    book.SetPages(sqlDataReader.GetInt32(4));
                    book.SetGenre(new TableGenres().GetGenre(sqlDataReader.GetInt32(5)));
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

        public Book GetBook(int uid)
        {
            Book book = new Book(uid);
            string command = "SELECT * FROM BOOK WHERE uid=" + book.GetUid();

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    book.SetName(sqlDataReader.GetString(1));
                    book.SetPrice(sqlDataReader.GetDouble(7));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return book;
        }

        public Book GetBook(string name)
        {
            Book book = new Book();
            string command = "SELECT * FROM BOOK WHERE name LIKE '" + name + "%'";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    book = new Book(sqlDataReader.GetInt32(0));
                    book.SetName(sqlDataReader.GetString(1));
                    book.SetPrice(sqlDataReader.GetDouble(7));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return book;
        }

        public void CreateBook(Book book)
        {
            string command = "INSERT INTO book(name, description, author, pages, genre, release_date, price) " +
                "VALUES(@name, @description, @author, @pages, @genre, @release_date, @price)";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@name", book.GetName());
            sqlCommand.Parameters.AddWithValue("@description", book.GetDescription());
            sqlCommand.Parameters.AddWithValue("@author", book.GetAuthor().GetUid());
            sqlCommand.Parameters.AddWithValue("@pages", book.GetPages());
            sqlCommand.Parameters.AddWithValue("@genre", book.GetGenre().GetUid());
            sqlCommand.Parameters.AddWithValue("@release_date", book.GetReleaseDate());
            sqlCommand.Parameters.AddWithValue("@price", book.GetPrice());

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateBook(int uid, Book book)
        {
            string command = "UPDATE book SET " +
                "name = @name, description = @description, author = @author, " +
                "pages = @pages, genre = @genre, release_date = @release_date, price = @price " +
                "WHERE uid = @uid";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@uid", uid);
            sqlCommand.Parameters.AddWithValue("@name", book.GetName());
            sqlCommand.Parameters.AddWithValue("@description", book.GetDescription());
            sqlCommand.Parameters.AddWithValue("@author", book.GetAuthor().GetUid());
            sqlCommand.Parameters.AddWithValue("@pages", book.GetPages());
            sqlCommand.Parameters.AddWithValue("@genre", book.GetGenre().GetUid());
            sqlCommand.Parameters.AddWithValue("@release_date", book.GetReleaseDate());
            sqlCommand.Parameters.AddWithValue("@price", book.GetPrice());

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteBook(Book book)
        {
            string command = "DELETE FROM book WHERE uid=" + book.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
