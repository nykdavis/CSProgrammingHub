﻿using System;
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
            Console.ReadKey();

            ForLoopProgram obj = new ForLoopProgram();
            obj.loopCheck();
        }
    }
}
