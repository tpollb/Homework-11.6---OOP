using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Homework_11._6___OOP
{

    /// <summary>
    /// Логика взаимодействия для DataGridViewWindow.xaml
    /// </summary>
    public partial class DataGridViewWindow : Window
    {
        public DataGridViewWindow()
        {
            InitializeComponent();

            Consultant user = new Consultant();
            user.LoadData();
            DataGrid1.ItemsSource = user.Clients;
        }

        /*
        public void LoadData1()
        {
            string queryString = $"SELECT * FROM Clients_Table";

            dataBase.openConnection();

            using (SqlCommand command = new SqlCommand(queryString, dataBase.getConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {   
                    while (reader.Read())
                    {
                        client.Name = (string)reader["name"];
                        client.Surname = (string)reader["surname"];
                        client.Middlename = (string)reader["middlename"];
                        client.Phonenumber = (uint)(double)reader["phonenumber"];
                        client.PassportSeries = (int)reader["passportseries"];
                        client.PassportNumber = (int)reader["passportnumber"];

                        clients.Add(client);
                    }
                }
            }
            Globals.Clientslist = clients;
            DataGrid1.ItemsSource = Globals.Clientslist;
        }
        */
    } 
}
