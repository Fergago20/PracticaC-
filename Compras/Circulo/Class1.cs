using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo.clas
{
    internal class Calculo
    {
        public double radio { get; set; }
        public double area ()
        {
            return Math.PI * (Math.Pow(radio, 2));
        }
    }
}
