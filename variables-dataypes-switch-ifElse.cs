using System;
using System.Linq.Expressions;

namespace variables_datatypes_switch
{
    class SwitchIfElseVarDatatypes
    {
        static void Main(string[] args)
        {
            int a = 18, b = 4, i = 0;
            string car = "engine";
            float c = 10.2F, d = 20.2F;
            Boolean m = true, n = false;
            if (a >= 18)
                Console.WriteLine("you are eligible to vote");
            else
                Console.WriteLine("you are not eligible to vote");
           
            switch (b)
            {
                case 1:  
                Console.WriteLine("sunday"); 
            break;
                case 2: 
                Console.WriteLine("monday");
            break;
                case 3:
                Console.WriteLine("tuesday");
            break;
                case 4:
                Console.WriteLine("wednesday"); break;
                case 5: 
                Console.WriteLine("thursday"); break;
                case 6: 
                Console.WriteLine("friday"); break;
                case 7: 
                Console.WriteLine("saturday"); break;
}
        }
    }
}