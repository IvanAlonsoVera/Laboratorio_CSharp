using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Alumno
    {
        private string _name;
        private string _edad;
        public Alumno()
        {
            Console.WriteLine("Nombre: ");
            _name = Console.ReadLine();
            Console.WriteLine("Edad: ");
            _edad = Console.ReadLine();
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre: {0}",_name);
            Console.WriteLine("Edad: {0}", _edad);
        }
        public void EsMayorEdad()
        {
            int edadAlumno = Convert.ToInt32(_edad);
            if(edadAlumno >= 18)
            {
                Console.WriteLine("{0} es mayor de edad",_name);
            }
            else
            {
                Console.WriteLine("{0} es menor de edad", _name);
            }
        }
    }
}
