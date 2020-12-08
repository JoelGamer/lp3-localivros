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
    class TableProviders : Connection
    {
        public List<Provider> GetAll()
        {
            List<Provider> providers = new List<Provider>();
            string command = "SELECT * FROM PROVIDERS";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Provider provider = new Provider(sqlDataReader.GetInt32(0));
                    provider.SetName(sqlDataReader.GetString(1));
                    provider.SetCNPJ(sqlDataReader.GetInt64(2));
                    provider.SetAddress(sqlDataReader.GetString(3));
                    provider.SetAddressNumber(sqlDataReader.GetString(4));
                    providers.Add(provider);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return providers;
        }

        public Provider GetProvider(int uid)
        {
            Provider provider = new Provider(uid);
            string command = "SELECT * FROM PROVIDERS WHERE uid=" + provider.GetUid();

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    provider.SetName(sqlDataReader.GetString(1));
                    provider.SetCNPJ(sqlDataReader.GetInt64(2));
                    provider.SetAddress(sqlDataReader.GetString(3));
                    provider.SetAddressNumber(sqlDataReader.GetString(4));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return provider;
        }

        public void CreateProvider(Provider provider)
        {
            string command = "INSERT INTO PROVIDERS(name, cnpj, address, address_number) " +
                "VALUES(@name, @cnpj, @address, @address_number)";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@name", provider.GetName());
            sqlCommand.Parameters.AddWithValue("@cnpj", provider.GetCNPJ());
            sqlCommand.Parameters.AddWithValue("@address", provider.GetAddress());
            sqlCommand.Parameters.AddWithValue("@address_number", provider.GetAddressNumber());

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateProvider(int uid, Provider provider)
        {
            string command = "UPDATE PROVIDERS SET " +
                "name = @name, cnpj = @cnpj, address = @address, address_number = @address_number " +
                "WHERE uid = @uid";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@uid", uid);
            sqlCommand.Parameters.AddWithValue("@name", provider.GetName());
            sqlCommand.Parameters.AddWithValue("@cnpj", provider.GetCNPJ());
            sqlCommand.Parameters.AddWithValue("@address", provider.GetAddress());
            sqlCommand.Parameters.AddWithValue("@address_number", provider.GetAddressNumber());

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteProvider(Provider provider)
        {
            string command = "DELETE FROM PROVIDERS WHERE uid=" + provider.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
