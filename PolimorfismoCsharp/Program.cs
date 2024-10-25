using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un array de métodos de pago
            MetodoPago[] metodosPago = new MetodoPago[3];
            metodosPago[0] = new TarjetaCredito();
            metodosPago[1] = new Paypal();
            metodosPago[2] = new Bitcoin();

            // Procesar un pago con cada método
            foreach (MetodoPago metodo in metodosPago)
            {
                metodo.ProcesarPago(100.00m); // Procesar un pago de $100
            }
        }
    }
}
