﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_Concatena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concatena c = new Concatena("ivan", "alonso");
            Console.WriteLine(c.Concatenar());
            Console.ReadKey(); 
        }
    }
}
