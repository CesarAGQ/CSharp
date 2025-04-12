using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDimensionesEsfera
{
    internal class Esfera
    {
        public double LeerEntrada()
        {
            double radio = 0;
            string input;

            while (true)
            {
                try
                {
                    input = Console.ReadLine(); // Leer la entrada del usuario

                    if (string.IsNullOrEmpty(input)) // Verificar si la entrada está vacía
                    {
                        Console.WriteLine("El radio no puede estar vacío. Inténtalo de nuevo.");
                        Console.Write("Introduce el radio de la esfera: ");
                        continue;
                    }

                    radio = double.Parse(input); // Convertir la entrada a un número

                    if (radio < 0) // Verificar si el radio es negativo
                    {
                        Console.WriteLine("El radio no puede ser negativo. Inténtalo de nuevo.");
                        Console.Write("Introduce el radio de la esfera: ");
                        continue;
                    }
                    break; // Salir del bucle si la entrada es válida
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
                    Console.Write("Introduce el radio de la esfera: ");
                }
            }
            return radio;
        }

    }
}