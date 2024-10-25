using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCsharp
{
    public class TarjetaCredito : MetodoPago
    {
        public override void ProcesarPago(decimal monto)
        {
            Console.WriteLine("Procesando el pago de {0:C} con tarjeta de crédito.", monto);
        }
    }
}
