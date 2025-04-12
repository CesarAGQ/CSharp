
namespace CalcularDimensionesEsfera
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("**** CALCULA LA SUPERFICIE Y VOLUMEN DE UNA ESFERA ****");
            Console.Write("*******************************************************\n\n");

            Console.Write("Introduce el radio de la esfera: ");

            Esfera esfera = new Esfera();
            Superficie superficie = new Superficie();
            Volumen volumen = new Volumen();

            double radio = esfera.LeerEntrada();
            double resultadoSup = superficie.CalcularSuperficie(radio);
            double resultadoVol = volumen.CalcularVolumen(radio);

            Console.WriteLine("\n************************************************************************");
            Console.WriteLine($"**** La superficie de la esfera con radio {radio} es: {resultadoSup} *****");
            Console.WriteLine($"**** El volumen de la esfera con radio {radio} es: {resultadoVol}    ******");
            Console.WriteLine("************************************************************************");
        }

    }
}
