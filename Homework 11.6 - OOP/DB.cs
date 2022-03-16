using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Homework_11._6___OOP
{
    public class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=USKOV; Initial Catalog=db; Integrated security=True");

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;   
        }
    }
}
