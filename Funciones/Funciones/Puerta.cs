using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
      public class Puerta
      {
            public float ancho;
            public float alto;
            public int color;
            public bool abierta;

            public Puerta()
            {
                ancho = 100;
                alto = 100;
                color = 23;
                abierta = true;
            }
            public Puerta(float ancho, float alto)
            {
                this.ancho = ancho;
                this.alto = alto;
            }
        public Puerta (float ancho, float alto, bool abierto)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.abierta=abierto;
        }
            public void DarColor(int n)
            {
                color = n;
            }
            public void DarAlto(int n)
            {
                alto = n;
            }
            public void DarAncho(int n)
            {
                ancho = n;
            }
            public void Abrir()
            {
                abierta = true;
            }
            public void Cerrar()
            {
                abierta = false;
            }
            public void MostrarEstado()
            {
                Console.WriteLine("ancho: {0} alto: {1} color: {2} estado: {3}", ancho, alto, color, abierta);
            }
      }

}
