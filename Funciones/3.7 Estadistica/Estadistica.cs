using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Estadistica
{
    internal class Estadistica
    {
        int n1;
        int n2;
        int n3;
        public Estadistica(int n1, int n2, int n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }
        public void Suma()
        {
            Console.WriteLine((n1 + n2 + n3));
        }
        public void Media()
        {
            Console.WriteLine(((n1 + n2 + n3)/3));
        }
    }
}
