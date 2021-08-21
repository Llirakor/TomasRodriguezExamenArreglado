using System;

namespace TomasRodriguezEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cateto1, Cateto2;

            Console.Write("Ingrese El Lado 1: ");
            Cateto1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese El Lado 2: ");
            Cateto2 = int.Parse(Console.ReadLine());

            double Hipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
            Console.WriteLine("La hipotenusa es: " + Hipotenusa);

            double Superficie = (Cateto1 + Cateto2) / 2;
            Console.WriteLine("El perimetro es: " + Superficie);

            double Perimetro = Cateto1 + Cateto2 + Hipotenusa;
            Console.WriteLine("El perimetro es: " + Perimetro);

            Console.ReadKey();
        }
    }
}
