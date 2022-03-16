using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Homework_11._6___OOP
{
    public class Consultant
    {
        DB dataBase = new DB();
        List<Client> clients = new List<Client>();
        private Client client = new Client();

        public Client Client { get => client; set => client = value; }
        public List<Client> Clients { get => clients; set => clients = value; }
        public DB DataBase { get => dataBase; set => dataBase = value; }

        public void LoadData()
        {
            DataBase.openConnection();
            string queryString = $"SELECT * FROM Clients_Table";

            using (SqlCommand command = new SqlCommand(queryString, DataBase.getConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Client.Name = (string)reader["name"];
                        Client.Surname = (string)reader["surname"];
                        Client.Middlename = (string)reader["middlename"];
                        Client.Phonenumber = (uint)(double)reader["phonenumber"];
                        Client.PassportSeries = (int)reader["passportseries"];
                        Client.PassportNumber = (int)reader["passportnumber"];
                        //Clients.Add(Client);

                        Globals.Clientslist.Add(Client);
                    }
                }
            }
            //return Clients;
        }
    }
}
