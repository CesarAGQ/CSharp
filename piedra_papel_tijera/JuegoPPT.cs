namespace Clases
{
    class JuegoPPT
    {
        public static bool nuevoJuego = true;
        private static string computadora, jugador;

        public static string Computadora
        {
            get { return computadora; }
            set { computadora = value; }
        }

        public static string Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public static void EleccionComputadora() // La computadora selecciona una opción entre piedra, papel y tijera.
        {
            Random random = new Random();

            switch (random.Next(1, 4))
            {
                case 1:
                    computadora = "piedra";
                    break;
                case 2:
                    computadora = "papel";
                    break;
                case 3:
                    computadora = "tijera";
                    break;
            }
        }

        public static void ResolucionJuego() // Se validan las combinaciones posibles del juego, para indicar un ganador.
        {

            if (jugador == computadora)
            {
                Console.WriteLine("Empate");
            }

            else if ((jugador == "piedra" && computadora == "tijera") ||
                     (jugador == "papel" && computadora == "piedra") ||
                     (jugador == "tijera" && computadora == "papel"))
            {
                Console.WriteLine("Ganaste");
            }

            else
            {
                Console.WriteLine("Perdiste");
            }

            Console.WriteLine("¿Tegustaría jugar otra ronda? (s/n)");
            char respuesta = Console.ReadLine().ToLower()[0];

            if (respuesta == 's')
            {
                nuevoJuego = true;
            }

            else
            {
                nuevoJuego = false;
            }

        }
    }
}
