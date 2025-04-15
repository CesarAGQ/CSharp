namespace
    DibujarUnCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write(x);

                Console.WriteLine();
            }
           
        }
    }
}