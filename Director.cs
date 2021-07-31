using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Director
    {
        public string FirstName;
        public string LastName;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
