using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TrabalhoLP3.Database
{
    class Connection
    {
        private readonly SqlConnection connection;

        public Connection()
        {
            connection = new SqlConnection(Properties.Settings.Default.SqlConnectionString);

            try
            {
                connection.Open();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public SqlCommand GenerateSqlCommand(string command)
        {
            return new SqlCommand(command, connection);
        }

        public DataTable GenerateDataTable(string command)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
