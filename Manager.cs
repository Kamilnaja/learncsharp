using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNMSPC
{
    class Manager : Employee
    {

        public Manager(string name) : base(name)
        {
            Console.WriteLine("Manager() " + name);
        }


        public string EmployeeId;
        private string Salary;
        private void Work()
        {

        }
        static void Manage()
        {

        }
    }
}
