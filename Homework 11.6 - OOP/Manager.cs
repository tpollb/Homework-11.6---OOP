using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11._6___OOP
{
    public class Manager : Consultant 
    {
        public override void LoadData()
        {
            //base.LoadData();
            DataBase.openConnection();
            string queryString = $"SELECT * FROM Clients_Table";

            using (SqlCommand command = new SqlCommand(queryString, DataBase.getConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clients.Add(new Client
                        {
                            Name = (string)reader["name"],
                            Surname = (string)reader["surname"],
                            Middlename = (string)reader["middlename"],
                            Phonenumber = (uint)(double)reader["phonenumber"],
                            PassportSeries = (int)reader["passportseries"],
                            PassportNumber = (int)reader["passportnumber"]
                        });
                    }
                }
            }
            DataBase.closeConnection();
        }

    }
}
