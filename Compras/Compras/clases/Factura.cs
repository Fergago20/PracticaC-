using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.clases
{
    internal class Factura
    {
        public string producto { get; set; }
        public double precio {  get; set; }
        public int cantidad { get; set; }
        public double calcularMonto()
        {
            return this.precio * this.cantidad;
        }
        public Factura() { }
    }
}
