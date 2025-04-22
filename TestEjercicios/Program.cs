namespace
    TestEjercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("*** Estadísticas matemáticas ***");
            Console.WriteLine("********************************");

            int total = 5;
            int[ ] numeros = new int[total];

            for (int  i = 0; i  < total; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0, media = 0, min = int.MinValue, max = int.MaxValue;

            for (int i = 0; i < total; i++)
            {
                int num = numeros[i];
                suma += num;

                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            media = suma / total;

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La media es: {media}");
            Console.WriteLine($"El número mínimo es: {min}");
            Console.WriteLine($"El número máximo es: {max}");

        }
    }
}
