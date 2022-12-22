using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Sucursal
    {
        private Cliente _cliente1, _cliente2, _cliente3;
        public Sucursal()
        {
            _cliente1 = new Cliente("joan");
            _cliente2 = new Cliente("Nicole");
            _cliente3 = new Cliente("Miguel");

        }
        public void Operar()
        {
            _cliente1.Depositar(100);
            _cliente2.Depositar(150);
            _cliente3.Depositar(200);

            _cliente3.Extraer(150);
        }
        public void DepositosTotales()
        {
            int total = _cliente1.RetornarMonto()+_cliente2.RetornarMonto()+_cliente3.RetornarMonto();

            Console.WriteLine("El dinero que hay es: {0}",total);
            _cliente1.Imprimir();
            _cliente2.Imprimir();
            _cliente3.Imprimir();
        }
    }
}
