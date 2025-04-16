namespace
    PositivoNegativo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*** El sistema identifica si el número digitado es positivo o negativo. ***");
            Console.WriteLine("***************************************************************************");

            Console.Write("Digite un número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
    }
}