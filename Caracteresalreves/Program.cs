namespace
    CaracteresalReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe 3 letras y se mostrarán al revés: ");

            string c1 = LeerLetra("Letra 1: ");
            string c2 = LeerLetra("Letra 2: ");
            string c3 = LeerLetra("Letra 3: ");

            Console.WriteLine("Las letras al reves son: {0} {1} {2}", c3, c2, c1);
        }

        static string LeerLetra(string msj)
        {
            string input;
            while (true)
            {
                Console.Write(msj);
                input = Console.ReadLine();


                if (!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsLetter(input[0]))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Error: No se permite números o caracter especial. Y debe ingresar solo una letra. ");
                }
            }

        }
    }
}