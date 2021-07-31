using ConsoleApp1;
using System;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("lorem mopsium");
            Employee emp = new Employee(10, 20000);
            Console.WriteLine(emp.Age);
            Console.WriteLine(emp.Salary);

            Student student = new Student();
            student.Grade = 3.7;
            Console.WriteLine("Grade : " + student.Grade);
            Director dir = new Director();
            dir.LastName = "jebaniec";
            dir.FirstName = "Joachim";
            Console.WriteLine(dir.FullName);
            Book book = null;
            Console.WriteLine(book);
        }

        

        public string toUpperCase(string s)
        {
            return s.ToUpper();
        }
    }

}
