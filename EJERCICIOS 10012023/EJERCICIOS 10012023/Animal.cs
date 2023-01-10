using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_10012023
{
    public class Animal
    {
        public string ClasePertenece;
        public string NombreAnimal;
        public Double Peso;
        public int Jaula;
        public Animal(string clasePertenece, string nombreAnimal, double peso, int jaula)
        {
            ClasePertenece = clasePertenece;
            NombreAnimal = nombreAnimal;
            Peso = peso;
            Jaula = jaula;
        }
        public virtual void ImprimirFicha()
        {
            Console.WriteLine("--------------Ficha--------------");
            Console.WriteLine("Clase Animal: {0}", ClasePertenece);
            Console.WriteLine("Nombre: {0}", NombreAnimal);
            Console.WriteLine("Peso: {0}Kg", Peso);
            Console.WriteLine("Jaula: {0}", Jaula);
            Console.WriteLine("---------------------------------");
        }
    }
}
