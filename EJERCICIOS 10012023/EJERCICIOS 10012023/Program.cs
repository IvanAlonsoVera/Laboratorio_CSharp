using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_10012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fecha fec = new Fecha();
            fec.MuestraFecha();
            fec.CambiaFecha(03, "Febrero", 1999);
            fec.MuestraFecha();
            Fecha fec2 = new Fecha(04,"Enero",2023);
            fec2.MuestraFecha();

            bool activador = true;
            int total = 0;
            do
            {
                int productoElegido;
                int resul = 0;
                Console.WriteLine("Nuestros productos: ");
                Console.WriteLine("1: Hamburguesa Sencilla: 15E");
                Console.WriteLine("2: Hamburguesa Con queso: 18E");
                Console.WriteLine("3: Hamburguesa especial: 20E");
                Console.WriteLine("4: Refresco: 5E");
                Console.WriteLine("5: Postre: 6E");
                Console.WriteLine("6: Pagar");
                productoElegido = Convert.ToInt32(Console.ReadLine());
                switch (productoElegido)
                {
                    case 1:
                        Console.WriteLine("¿Cuantas unidades de hamburguesas sencillas?");
                        int unidadUsuario = Convert.ToInt32(Console.ReadLine());
                        resul = 15 * unidadUsuario;
                        break;
                    case 2:
                        Console.WriteLine("¿Cuantas unidades de hamburguesa de queso?");
                        int unidadUsuario2 = Convert.ToInt32(Console.ReadLine());
                        resul = 18 * unidadUsuario2;
                        break;
                    case 3:
                        Console.WriteLine("¿Cuantas unidades de hamburguesa especial?");
                        int unidadUsuario3 = Convert.ToInt32(Console.ReadLine());
                        resul = 20 * unidadUsuario3;
                        break;
                    case 4:
                        Console.WriteLine("¿Cuantos refrescos?");
                        int unidadUsuario4 = Convert.ToInt32(Console.ReadLine());
                        resul = 5 * unidadUsuario4;
                        break;
                    case 5:
                        Console.WriteLine("¿Cuantos postres?");
                        int unidadUsuario5 = Convert.ToInt32(Console.ReadLine());
                        resul = 6 * unidadUsuario5;
                        break;
                    case 6:
                        if (total > 0)
                            Console.WriteLine("El resultado a pagar es {0}E", total);
                        else
                            Console.WriteLine("El resultado a pagar es 0E");
                        activador = false;
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no esta disponible, selecciona otra por favor");
                        break;
                }
                total += resul;
            } while (activador);

            Mamifero leon = new Mamifero("leon", "Simba", 200, 32, 4);
            leon.ImprimirFicha();
            leon.Rugir();
            Animal Rana = new Animal("Rana", "Gustabo", 0.5, 2);
            Rana.ImprimirFicha();
            Ave gaviota = new Ave("Gaviota", "blanqui", 1, 45);
            gaviota.ImprimirFicha();
            gaviota.Volar();

            Console.WriteLine("Introduzca 3 Jugadores");
            ArrayList Jugadores = new ArrayList();
            ArrayList Indices = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Introduzca Jugador: ");
                Jugadores.Add(Console.ReadLine());
                Console.Write("Introduzca peso en Kg: ");
                int peso = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca altura en Cm: ");
                int altura = Convert.ToInt32(Console.ReadLine());
                Indices.Add(peso/Math.Pow(altura,2));
            }
            string myfile = @"file.txt";
            for (int i = 0; i < Indices.Count; i++)
            {
                using (StreamWriter sw = File.AppendText(myfile))
                {
                    sw.WriteLine("El Jugador: {0} tiene un IMC de: {1}",Jugadores[i], Indices[i]);
                }
            }
            using (StreamReader sr = File.OpenText(myfile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }
    }
}
