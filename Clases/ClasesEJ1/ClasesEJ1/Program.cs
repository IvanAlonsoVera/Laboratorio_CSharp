using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Random rand = new Random();
            int n1 = rand.Next(0, 10);
            int n2 = rand.Next(10, 20);
            int s = 0;
            Console.WriteLine("Los Numeros son: {0} y {1}", n1, n2);
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            Console.Write("¿Que desea hacer?");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1": 
                        s = n1 + n2;
                break;
                case "2":
                    s = n1 - n2;
                    break;
                case "3":
                    s = n1 * n2;
                    break;
                case "4":
                    s = n1 / n2;
                    break;
                default:
                    Console.Write("Ocurrio un Error");
                    break;
            }
            Console.Write("La solucion es: {0}",s);

            //Circunferencia Rueda = new Circunferencia();
            //Circunferencia Moneda = new Circunferencia();
            //Rueda.ModRadio((float)10.2);
            //Moneda.ModRadio((float)1.4);
            //Rueda.Area();
            //Moneda.Area();
            //Rueda.Perimetro();
            //Moneda.Perimetro();
            Console.ReadKey();
        }
    }
}
