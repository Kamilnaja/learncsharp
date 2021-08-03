namespace Project04a
{
    using System;
    public class Demo
    {
        public void Test()
        {
            Console.WriteLine("Testing");
        }

        public void PrintString(String myString)
        {
            Console.WriteLine(myString);
        }

        public void PrintString(String myString, int offset)
        {
            Console.WriteLine(myString + "x");
        }
    }
}
