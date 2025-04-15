namespace
    CalculadoraUsandoIf
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("*** Bienvenido a la calculadora ***");
            Console.WriteLine("***********************************");
            //---------------------------------------------------------------
            Program calculadora = new Program();

            double num1 = calculadora.ValidarValorInput("Digite el primer número: ");

            double num2 = calculadora.ValidarValorInput("Digite el segundo número: ");
            //---------------------------------------------------------------

            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("1. Sumar (+)");
            Console.WriteLine("2. Restar (-)");
            Console.WriteLine("3. Multiplicar (*)");
            Console.WriteLine("4. Dividir (/)");

            char operador = calculadora.ValidarOperador("Ingrese el operador para realizar el calculo: ");
            //---------------------------------------------------------------

            try
            {
                double resultado = MostrarResultado(num1, num2, operador);
                Console.WriteLine($"\nEl resultado es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }

        public double ValidarValorInput(string msj)
        {
            while (true)
            {
                Console.Write(msj);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada invalida. El valor no puede estar vacío.");
                    continue;
                }

                if (!double.TryParse(input, out double valor))
                {
                    Console.WriteLine("Entrada invalida. Por favor, ingrese un número válido.");
                    continue;
                }
                return valor;
            }
        }

        public char ValidarOperador(string msj)
        {
            while (true)
            {
                Console.Write(msj);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Entrada invalida. El valor no puede estar vacío.");
                    continue;
                }

                if (input.Length != 1)
                {
                    Console.WriteLine("Entrada invalida. El operador debe ser un solo caracter.");
                    continue;
                }

                char operador = input[0];

                if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                {
                    Console.WriteLine("Entrada invalida. Por favor, ingrese un operador válido (+, -, *, /).");
                    continue;
                }
                return operador;
            }
        }

        public static double MostrarResultado(double num1, double num2, char operador)
        {
            if (operador == '+')
            {
                return num1 + num2;
            }
            else if (operador == '-')
            {
                return num1 - num2;
            }
            else if (operador == '*')
            {
                return num1 * num2;
            }
            else if (operador == '/')
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir entre cero.");
                }
            }
           throw new InvalidOperationException("Operador no válido.");
        }
    }
}