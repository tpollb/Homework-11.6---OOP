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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_11._6___OOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DataGridViewWindow w = new DataGridViewWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Selec_User_Button_Click(object sender, RoutedEventArgs e)
        {
            Globals.UserName = user_list_ComboBox.Text;

            w.Show();
            this.Close();   
        }
    }
}
