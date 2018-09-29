using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Resta : Operacion
    {
        public override decimal Operar(decimal x, decimal y)
        {
            return x - y;
        }
    }
}
