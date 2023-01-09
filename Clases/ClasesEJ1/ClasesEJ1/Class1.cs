using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEJ1
{
    public class Circunferencia
    {
        float Radio = 2;
        public void Area()
        {
            Console.WriteLine(3.14 * Math.Pow(Radio,2)); ;
        }
        public void Perimetro()
        {
            Console.WriteLine((2*3.14) * Radio);
        }
        public void ModRadio(float nRadio)
        {
            Radio = nRadio;
        }
        public void MosRadio()
        {
            Console.WriteLine("El Radio es: {0}",Radio);
        }
    }
}
