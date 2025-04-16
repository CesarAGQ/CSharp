using System.Diagnostics;

namespace
    CalculadoraSwitch
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("*** Bienvenido a la calculadora ***");
            Console.WriteLine("***********************************");

            try
            {
                double num1 = ValidarInput("Ingrese el primer número: ");
                double num2 = ValidarInput("Ingrese el segundo número: ");
                char operador = ValidarOperador("Ingrese el operador (+, -, *, /): ");

                Calculadora(num1, num2, operador);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
            }
        }
//******************************* Metodos *********************************************************************************        

        static void Calculadora(double num1, double num2, char operador)
        { 
            switch (operador)
            {
                case '+':
                    Console.WriteLine($"\nSuma de los números {num1} + {num2} = {num1 + num2}");
                    break
                        ;
                case '-':
                    Console.WriteLine($"\nResta de los números {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"\nMultiplicación de los números {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"\nDivisión de los números {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: División por cero no permitida.");
                    }
                    break;

                default:
                    Console.WriteLine("\nOperador no válido. Por favor, use +, -, * o /.");
                    break;
            }
        }
        static double ValidarInput(string msj)
        { 
            while (true)
            {
                Console.Write(msj);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Error, no se puede dejar el campo vacío. Intente de nuevo");
                    continue;
                }

                if (!double.TryParse(input, out double num))
                {
                    Console.WriteLine("Error, el valor ingresado no es un número. Intente de nuevo");
                    continue;
                }
                
                return num;
            }

        }

        static char ValidarOperador(string msj)
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

    }
}