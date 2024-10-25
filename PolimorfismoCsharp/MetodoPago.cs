using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCsharp
{
    public abstract class MetodoPago
    {
        public abstract void ProcesarPago(decimal monto);
    }
}
