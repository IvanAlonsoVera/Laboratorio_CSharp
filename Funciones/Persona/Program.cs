using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "javier";
            DateTime fechanac = new DateTime(2010,8,18);
            p.Saludar();

            Console.ReadKey();
        }
    }
}
