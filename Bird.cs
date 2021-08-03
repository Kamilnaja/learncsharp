using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bird: Animal
    {
        public int NumberOfWings;

        public Bird(int numberOfWings)
        {
            NumberOfWings = numberOfWings;
        }

        void fly()
        {
            Console.WriteLine("I believe I can fly");
        }
    }
}
