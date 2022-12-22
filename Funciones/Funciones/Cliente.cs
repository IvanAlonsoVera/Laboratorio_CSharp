using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Cliente
    {
        private string _nombre;
        private int _importeIngresar;

        public Cliente (string nom)
        {
            _nombre = nom;
            _importeIngresar = 0;

        }

        public void Depositar (int m)
        {
            _importeIngresar = _importeIngresar + m;
        }
        public void Extraer(int m)
        {
            _importeIngresar = _importeIngresar - m;

        }
        public int RetornarMonto()
        {
            return _importeIngresar;
        }
        public void Imprimir()
        {
            Console.WriteLine("{0} tiene depositados {1}", _nombre, _importeIngresar);
        }
    }
}
