using CalcularDimensionesEsfera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDimensionesEsfera
{
    internal class Volumen
    {
        public double CalcularVolumen(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3); // Calcular el volumen de la esfera
        }
    }
}
