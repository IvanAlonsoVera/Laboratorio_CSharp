using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Estadistica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estadistica e = new Estadistica(1, 2, 3);
            e.Suma();
            e.Media();
            Console.ReadKey();
        }
    }
}
