using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Circulo : Formas
    {
        public Circulo(double radio):base(radio,0)
        {

        }
        public override double Area()
        {
            return pi * x * x;
        }
    }
}
