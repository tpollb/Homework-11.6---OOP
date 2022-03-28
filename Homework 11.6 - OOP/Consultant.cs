using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows;

namespace Homework_11._6___OOP
{
    public class Consultant
    {
        private DB dataBase = new DB();
        private List<Client> clients = new List<Client>();

        public List<Client> Clients { get => clients; set => clients = value; }
        public DB DataBase { get => dataBase; set => dataBase = value; }

        public virtual void LoadData()
        {
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
                            PassportSeries = 0,
                            PassportNumber = 0
                        });
                    }
                }
            }
            DataBase.closeConnection();
        }
    }
}
