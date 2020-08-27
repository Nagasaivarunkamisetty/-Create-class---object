using System;

namespace Class_and_objects
{
    class Program
    { 
        void display()
        {
            Console.WriteLine("WELCOME TO C# !");
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.display();
        }
    }
}
