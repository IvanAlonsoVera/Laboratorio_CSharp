using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Coordenadas
    {
        int _x, _y;

        public Coordenadas()
        {
            _x = 0;
            _y = 0;
        }
        public Coordenadas(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",_x, _y);
        }
    }
}
