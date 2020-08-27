using System;

namespace Class_and_objects
{
    class ClassObjects
    { 
        void display()
        {
            Console.WriteLine("WELCOME TO C# !");
        }
        static void Main(string[] args)
        {
            ClassObjects a = new ClassObjects();
            a.display();
        }
    }
}
