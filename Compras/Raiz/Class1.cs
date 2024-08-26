using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate.Raiz
{
    internal class Calculo
    {
        public double numero {get; set;}
        public double resultado ()
        {
            return Math.Sqrt(numero);
        }
    }
}
