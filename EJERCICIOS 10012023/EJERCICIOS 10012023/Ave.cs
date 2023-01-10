using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_10012023
{
    internal class Ave : Animal
    {
        public Ave(string clasePertenece, string nombreAnimal, double peso, int jaula) : base(clasePertenece, nombreAnimal, peso, jaula)
        {
        }
        public void Volar()
        {
            Console.WriteLine("Estoy Volando");
        }
    }
}
