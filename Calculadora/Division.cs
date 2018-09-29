using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Division : Operacion
    {
        public override decimal Operar(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new Exception("El divisor no puede ser 0");
            } else
            {
                return x / y;
            }
        }
    }
}
