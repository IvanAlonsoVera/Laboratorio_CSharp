using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Funciones
{
    public class Date
    {
        private int _month = 7;
        public int Month 
        { 
            get => _month;
            set
            {
                if((value > 0)&&(value < 12))
                {
                    _month = value;
                }
            }
        }
    }
}