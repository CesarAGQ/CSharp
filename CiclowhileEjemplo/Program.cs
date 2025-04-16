namespace
    UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //************************While*************************
            int i = Convert.ToInt32(Console.ReadLine());

            while (i != 0)
            {
                Console.WriteLine($"while: {i * 10}");
                i = Convert.ToInt32(Console.ReadLine());
            }
            //************************Do While*********************

            int j = Convert.ToInt32(Console.ReadLine()); ;
            do
            {
                Console.WriteLine($"dowhile: {j * 10}");
                j = Convert.ToInt32(Console.ReadLine());

            } while (j != 0);
        }
    }
}