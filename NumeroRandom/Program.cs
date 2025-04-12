using System;

namespace
    NumeroRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce 2 números. Y el sistema mostrará número aleatorio entre los 2 valores introducidos.");
            
            int liminf = ValidarLimites("Introduce el primer número: "); 
            int limsup = ValidarLimites("Introduce el segundo número: ");


            Console.WriteLine("Número 1: " + liminf);
            Console.WriteLine("Número 2: " + limsup);

            MostrarNumeroAleatorio(liminf, limsup);
        }
        public static void MostrarNumeroAleatorio(int liminf, int limsup)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(liminf, limsup);
            Console.WriteLine("Número aleatório generado: " + numeroAleatorio);
        }
        public static int ValidarLimites( string msj)
        {
            while (true)
            {
                Console.Write(msj);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    continue;
                }
                if (!int.TryParse(input, out int numero))
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    continue;
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Por favor, introduce un número mayor que 0.");
                    continue;
                }
                else
                {
                    return numero;
                }

            }
        }
    }

}