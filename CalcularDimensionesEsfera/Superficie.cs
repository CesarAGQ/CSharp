using CalcularDimensionesEsfera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDimensionesEsfera
{
    internal class Superficie
    {
        public double CalcularSuperficie(double radio)
        {
            return 4 * Math.PI * Math.Pow(radio, 2); // Calcular la superficie de la esfera
        }
    }
}
