using ConsoleApp1;
using System;

namespace EmployeeNMSPC
{
    using Project04a;
    using System.Text;

    class Program
    {
        static void Main()
        {
            DiceRoll dr = new DiceRoll();
            dr.Test();
        }

        public string toUpperCase(string s)
        {
            return s.ToUpper();
        }
    }

}
