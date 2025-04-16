using System;

namespace
    ElmayordeTresNumeros
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*** Mostrar el mayor de tres numeros ***");
            Console.WriteLine("****************************************");

            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            //***********************************************************************
            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }
            //************************************************************************

            int menor = num1;

            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }
            //************************************************************************
            Console.WriteLine($"El mayor es: {mayor} y el menor es: {menor}");
        }
    }
}