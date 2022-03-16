using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11._6___OOP
{
    public class Globals
    {
        private static string userName;
        private static List<Client> clientslist;

        public static string UserName { get => userName; set => userName = value; }
        public static List<Client> Clientslist { get => clientslist; set => clientslist = value; }
    }
}
