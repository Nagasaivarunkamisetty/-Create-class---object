using System;
using System.Transactions;

namespace whiler
{
    class Whiler
{
    static void Main(string[] args)
    {
     int i=1,c,j;
            string var;
 Console.WriteLine("enter a number"); 
         var = Console.ReadLine();
            c = Convert.ToInt32(var);        
            
            while (i <= 10)
        {
                j = c * i;
            Console.WriteLine(j);
            i++;
        }
    }
}
}
