using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3
{
    internal class Program
    {
        struct tipoFicha
        {
            public string nombreFich;
            public long tamaño;
        }
        static void Main(string[] args)
        {
            tipoFicha[] fichas = new tipoFicha[1000];
            int numeroFichas = 0;
            int opcion;
            int tamañoBusqueda;
            string ficheroBusqueda;
            do
            {
                Console.WriteLine("elije opcion: ");
                Console.WriteLine("1-Añadir datos");
                Console.WriteLine("2-Mostrar nombres ficheros");
                Console.WriteLine("3-Ficheros mayores de un determinado tamaño");
                Console.WriteLine("4-Ver datos de un fichero");
                Console.WriteLine("5-Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if(numeroFichas < 1000)
                        {
                            Console.Write("Nombre del Fichero?: ");
                            fichas[numeroFichas].nombreFich = Console.ReadLine();
                            Console.Write("Tamaño del Fichero?: ");
                            fichas[numeroFichas].tamaño = Convert.ToInt64(Console.ReadLine());
                            numeroFichas++;
                        }
                        else
                        {
                            Console.WriteLine("Completo");
                        }
                        break;
                    case 2:
                        foreach(var ficha in fichas)
                        {
                            if (ficha.nombreFich != null)
                            {
                                Console.WriteLine(ficha.nombreFich);
                            }
                            else
                            {
                                
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("A partir de que tamaño?: ");
                        tamañoBusqueda = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numeroFichas; i++)
                        {
                            if (fichas[i].tamaño >= tamañoBusqueda)
                            {
                                Console.WriteLine("Nombre: {0} - Tamaño {1}", fichas[i].nombreFich, fichas[i].tamaño);
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Que fichero quieres? ");
                        ficheroBusqueda= Console.ReadLine();
                        for (int i = 0; i < numeroFichas; i++)
                        {
                            if (fichas[i].nombreFich == ficheroBusqueda)
                            {
                                Console.WriteLine("Nombre: {0} - Tamaño {1}", fichas[i].nombreFich, fichas[i].tamaño);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("fin");
                        break;
                    default:
                        break;
                }
            } while (opcion != 5);

            Console.ReadLine();
        }
    }
}
