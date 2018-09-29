using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public abstract class Operacion
    {
        public abstract decimal Operar(decimal x, decimal y);
    }
}
