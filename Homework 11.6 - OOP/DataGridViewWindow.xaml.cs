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

            MessageBox.Show($"{Globals.UserName}");

            Consultant user = new Consultant();

            if (Globals.UserName == "Manager")
            {
                user = new Manager();
            }

            user.LoadData();

            DataGrid1.Items.Clear();
            DataGrid1.ItemsSource = user.Clients;
        }
    } 
}
