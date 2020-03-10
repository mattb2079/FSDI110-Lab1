using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
        }

        static void Test()
        {
            Console.WriteLine("This is a method");

            /* Variables and Data types */
            string firstName = "Matt";
            Console.WriteLine("My name is " + firstName);

            int age = 99;
            long seconds = 1298031829031831;

            float price = 12.34f;

            decimal price2 = 123.23m;

            bool isThiscrazy = true;

            // if statements
            if(isThiscrazy)
            {
                Console.WriteLine("Yeah it is");
            }
            else{
                Console.WriteLine("No, it's not");
            }

            // loops
            for(int i=0; i<10; i++){
                Console.WriteLine("Iteration: " + i);
            }

        }
    }
}
