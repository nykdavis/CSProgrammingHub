using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first CSharp Program");

            //  ForLoopProgram obj = new ForLoopProgram();
            // obj.loopCheck();
            IfPrograms obj = new IfPrograms();
            obj.ifCheck();
            obj.ifElseCheck();


            Console.ReadKey();



        }
    }
}
