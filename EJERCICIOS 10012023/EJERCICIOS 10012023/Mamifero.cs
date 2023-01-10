using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_10012023
{
    internal class Mamifero : Animal
    {
        public Mamifero(string clasePertenece, string nombreAnimal, double peso, int jaula, int edad) : base(clasePertenece, nombreAnimal, peso, jaula)
        {
            this.edad = edad;
        }
        public int edad;

        public override void ImprimirFicha()
        {
            Console.WriteLine("--------------Ficha--------------");
            Console.WriteLine("Clase Animal: {0}", ClasePertenece);
            Console.WriteLine("Nombre: {0}", NombreAnimal);
            Console.WriteLine("Peso: {0}Kg", Peso);
            Console.WriteLine("Jaula: {0}", Jaula);
            Console.WriteLine("Edad: {0} Años", edad);
            Console.WriteLine("---------------------------------");
            
        }
        public void Rugir()
        {
            Console.WriteLine("Rugiendo GRR");
        }
    }
}
