using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concesionario concesionario = new Concesionario(10);
            Coche c1 = new Coche(1, "BMW", "4", 1000, 12000);
            Coche c2 = new Coche(2, "Toyota", "auris", 0, 12000);
            Coche c3 = new Coche(3, "Seat", "Ibiza", 2000, 15000);
            Coche c4 = new Coche(4, "Ferrari", "rosca", 1000, 20000);
            Coche c5 = new Coche(5, "Peugeout", "206", 100000, 30000);

            concesionario.AñadirCoche(c1);
            concesionario.AñadirCoche(c2);
            concesionario.AñadirCoche(c3);
            concesionario.AñadirCoche(c4);
            concesionario.AñadirCoche(c5);

            Console.WriteLine("Todos los Coches");
            concesionario.MostrarCoches();

            concesionario.EliminarCoche(c3);
            concesionario.MostrarCoches();
            //concesionario.EliminarCoche(c1);

            //Console.WriteLine("Elimino 2 coches");
            //concesionario.MostrarCoches();

            //concesionario.AñadirCoche(c3);
            //Console.WriteLine("Añadir uno mas");
            //concesionario.MostrarCoches();
            //Sucursal sucursal = new Sucursal();
            //sucursal.Operar();
            //sucursal.DepositosTotales();
            Console.ReadKey();
        }
    }
}
