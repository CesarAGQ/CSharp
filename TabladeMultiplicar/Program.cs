using static System.Runtime.InteropServices.JavaScript.JSType;

namespace
    TabladeMultiplicar
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*** TABLAS DE MULTIPLICAR. ***");
            Console.WriteLine("******************************");

            Console.WriteLine("¿Qué tabla quieres mostrar?");
            int tabla = Convert.ToInt32(ValidarNumero("Escribe un número: "));    

            Console.WriteLine("¿Hasta qué número quieres ver la tabla?");
            Console.Write("Escribe un número: ");
            int limite = Convert.ToInt32(ValidarNumero("Escriba un número: "));

            MostrarTabla(tabla, limite);
        }

        private static int ValidarNumero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string input = Console.ReadLine();

                // Validar que la entrada no sea nula o vacía
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número.");
                    continue;
                }

                // Validar que la entrada sea un número entero
                if (!int.TryParse(input, out int numero))
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número válido.");
                    continue;
                }

                // Validar que el número sea positivo
                else if (numero <= 0)
                {
                    Console.WriteLine("Número inválido. Debe ser un número positivo.");
                    continue;
                }

                // Si todas las validaciones pasan, devolver el número
                return numero;
            }
        }

        private static void MostrarTabla(int tabla, int limite)
        {
            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {tabla * i}");
            }
        }
    }
}

    