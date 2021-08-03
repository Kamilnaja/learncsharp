using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNMSPC
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee()");
        }

        public Employee(string name)
        {
            Console.WriteLine("wołany z subklasy");
            Console.WriteLine("Employee() " + name);
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        public Employee(int AgeValue, int SalaryValue)
        {
            Age = AgeValue;
            Salary = SalaryValue;
        }
    }


}
