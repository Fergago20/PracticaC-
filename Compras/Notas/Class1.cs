using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.clas
{
    internal class Nota
    {
        public string Asignatura { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double promedio()
        {
            return (this.nota1 + this.nota2 + this.nota3) / 3;
        }

    }
}
