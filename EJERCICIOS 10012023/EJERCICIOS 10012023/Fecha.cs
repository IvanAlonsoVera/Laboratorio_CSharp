using System;

namespace EJERCICIOS_10012023
{
    internal class Fecha
    {
        public int Dia;
        public string Mes;
        public int Año;
        public Fecha()
        {
            Dia = 01;
            Mes = "Enero";
            Año = 2000;
        }
        public Fecha(int _dia, string _mes, int _año)
        {
            Dia = _dia;
            Mes = _mes;
            Año = _año;
        }
        public void CambiaFecha(int _dia, string _mes, int _año)
        {
            Dia = _dia;
            Mes = _mes;
            Año = _año;
        }
        public void MuestraFecha()
        {
            Console.WriteLine("Dia: {0} Mes: {1} Año: {2}", Dia, Mes, Año);
        }
    }
}
