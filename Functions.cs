using System;

namespace ConsoleApp5
{
    public class Functions
    {
      void greatest(int a, int b, int c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is greatest");
            else if (b > a && b > c)
                Console.WriteLine("b is greatest");
            else
                Console.WriteLine("c is greatest");


        }
     public static void Main(string[] args)
        {
            Functions varun = new Functions();
            varun.greatest(4, 5, 6);

        
        }
    }
}