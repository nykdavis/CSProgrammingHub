using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharpHub
{
    internal class IfPrograms
    {
        //  if statement
        //  if-else statement
   

       public void ifElseCheck()
        {
            Console.WriteLine("Enter your Age ::");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Elligible for DL");
            }
            else
            {
                Console.WriteLine("Not elligible for DL");
            }
        }
        
        public void ifCheck()
        {   
            Console.WriteLine("Enter Value ::");
            int value = int.Parse(Console.ReadLine());
            if (value > 10) 
            {
                Console.WriteLine("Satisfying conditions  " + value);
            }
        }

    }
}
