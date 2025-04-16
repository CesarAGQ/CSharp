namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            while (JuegoPPT.nuevoJuego)
            {
                Console.Clear(); // limpoar la pantalla

                Console.Write("Ingresa piedra, papel o tijera: ");
                JuegoPPT.Jugador = Console.ReadLine().ToLower();

                while (JuegoPPT.Jugador != "piedra" && JuegoPPT.Jugador != "papel" && JuegoPPT.Jugador != "tijera")
                {
                    Console.Write("Ingresa una opción válida: ");
                    JuegoPPT.Jugador = Console.ReadLine().ToLower();
                }


                JuegoPPT.EleccionComputadora(); // La computadora selecciona una opción entre piedra, papel y tijera.

                Console.WriteLine($"jugador: {JuegoPPT.Jugador}");
                Console.WriteLine($"computadora: {JuegoPPT.Computadora}");

                JuegoPPT.ResolucionJuego(); // Se validan las combinaciones posibles del juego, para indicar un ganador.

            }
            Console.WriteLine("Gracias por jugar!");

        }

    }
}
