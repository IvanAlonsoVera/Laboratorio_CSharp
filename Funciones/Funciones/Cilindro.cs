using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Cilindro : Circulo
    {
        public Cilindro(double radio, double altura):base(radio)
        {
            y=altura;
        }
        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }

}

