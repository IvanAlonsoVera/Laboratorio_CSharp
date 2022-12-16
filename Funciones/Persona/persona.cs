using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Persona
    {
        internal string nombre;

        public class Persona
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public DateTime fechanac { get; set; }
            private int CalcularEdad(DateTime fecha)
            {
                int año = fecha.Year;
                int actual = DateTime.Now.Year;
                return actual - año;
                
            }
            public void Saludar()
            {
                Console.WriteLine("Hola soy {0} y tengo {1}", nombre, CalcularEdad(fechanac));
            }

        }
    }
}
