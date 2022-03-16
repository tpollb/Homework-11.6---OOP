using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11._6___OOP
{
    public class Client
    {
        private string name;
        private string surname;
        private string middlename;
        private uint phonenumber;
        private int passportSeries;
        private int passportNumber;


        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public uint Phonenumber { get => phonenumber; set => phonenumber = value; }
        public int PassportSeries { get => passportSeries; set => passportSeries = value; }
        public int PassportNumber { get => passportNumber; set => passportNumber = value; }
    }
}
