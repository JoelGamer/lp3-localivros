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
    class TableSales : Connection
    {
        public List<Sale> GetAll()
        {
            List<Sale> sales = new List<Sale>();
            string command = "SELECT * FROM SALES";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Sale sale = new Sale(sqlDataReader.GetInt32(0));
                    sale.SetBook(new TableBooks().GetBook(sqlDataReader.GetInt32(1)));
                    sale.SetClient(new TableClients().GetClient(sqlDataReader.GetInt32(2)));
                    sale.SetQuantity(sqlDataReader.GetInt32(3));
                    sales.Add(sale);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return sales;
        }

        public List<Sale> GetAll(int bookUID)
        {
            List<Sale> sales = new List<Sale>();
            string command = "SELECT * FROM SALES WHERE book_uid=" + bookUID;

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Sale sale = new Sale(sqlDataReader.GetInt32(0));
                    sale.SetBook(new TableBooks().GetBook(sqlDataReader.GetInt32(1)));
                    sale.SetClient(new TableClients().GetClient(sqlDataReader.GetInt32(2)));
                    sale.SetQuantity(sqlDataReader.GetInt32(3));
                    sales.Add(sale);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return sales;
        }

        public Sale GetSale(int uid)
        {
            Sale sale = new Sale(uid);
            string command = "SELECT * FROM SALES WHERE uid=" + sale.GetUid().ToString();

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    sale.SetBook(new TableBooks().GetBook(sqlDataReader.GetInt32(1)));
                    sale.SetClient(new TableClients().GetClient(sqlDataReader.GetInt32(2)));
                    sale.SetQuantity(sqlDataReader.GetInt32(3));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return sale;
        }

        public void CreateSale(Sale sale)
        {
            string command = "INSERT INTO SALES(book_uid, client_uid, quantity) " +
                "VALUES(@book_uid, @client_uid, @quantity)";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@book_uid", sale.GetBook().GetUid());
            sqlCommand.Parameters.AddWithValue("@client_uid", sale.GetClient().GetUid());
            sqlCommand.Parameters.AddWithValue("@quantity", sale.GetQuantity());

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateSale(int uid, Sale sale)
        {
            string command = "UPDATE SALES SET " +
                "book_uid = @book_uid, client_uid = @client_uid, quantity = @quantity " +
                "WHERE uid = @uid";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@uid", uid);
            sqlCommand.Parameters.AddWithValue("@book_uid", sale.GetBook().GetUid());
            sqlCommand.Parameters.AddWithValue("@client_uid", sale.GetClient().GetUid());
            sqlCommand.Parameters.AddWithValue("@quantity", sale.GetQuantity());

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteSale(Sale sale)
        {
            string command = "DELETE FROM SALES WHERE uid=" + sale.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
