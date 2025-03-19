using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals
{
    internal class Retangulo:IForma
    {
        public double Altura;
        public double Largura;

        public double CalcularArea()
        {
            return Altura * Largura;
        }

    }
}
