using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo.clas
{
    internal class Calculo
    {
        public double numero { get; set; }
        public double potencia()
        {
            return Math.Pow(this.numero, 3);
        }
    }
}
