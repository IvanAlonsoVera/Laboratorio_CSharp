using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Porton : Puerta
    {
        public Porton()
        {
            ancho = 450;
            alto = 345;
            color = 15;
            abierta = false;
            Bloqueada = false;
        }
        public bool Bloqueada { get; set; }
        public void Bloquear()
        {
            Bloqueada = true;
        }
        public void Desbloquear()
        {
            Bloqueada = false;
        }
        public void MostrarEstado()
        {
            Console.WriteLine("ancho: {0} alto: {1} color: {2} estado: {3} bloqueado: {4}", ancho, alto, color, abierta, Bloqueada);
        }

    }
}
