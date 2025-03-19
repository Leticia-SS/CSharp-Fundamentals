using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals
{
    internal class Circulo:IForma
    {
        public double Raio;  

        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

    }
}
