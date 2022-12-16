using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_Concatena
{
    internal class Concatena
    {
        string nombre;
        string apellido;
        public Concatena(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }   
        public String Concatenar()
        {
            return string.Format("{0},{1}", nombre, apellido);
        }
    }
}
