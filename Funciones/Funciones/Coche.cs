using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Coche
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private int _Km;
        private double _precio;
        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            _id = id;
            _marca = marca;
            _modelo = modelo;
            _Km = km;
            _precio = precio;
        }
            public int Id { get => _id; set => _id = value; }
            public string Marca { get => _marca; set => _marca = value; }
            public string Modelo { get => _modelo; set => _modelo = value; }
            public int Km { get => _Km; set => _Km = value; }
            public double Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return string.Format("Marca: {0}, Modelo: {1}, Km: {2}, Precio: {3}",_marca,_modelo,_Km,_precio);
        }
    }
}
