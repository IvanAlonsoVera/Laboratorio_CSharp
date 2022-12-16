using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class employee
    {
        public int _salary { get; set; }

        public employee(int anualSalary)
        {
            _salary = anualSalary;
        }
        public employee(int weekleySalary, int numberOfWeeks): this(weekleySalary * numberOfWeeks)
        {

        }
    }
}
