using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shape
    {
        public void WhatIAm()
        {
            Console.WriteLine("I' am a shape");
        }
    }

    class Oval: Shape
    {
        new public void WhatIAm()
        {
            Console.WriteLine("I'am an oval");
        }
    }
}

