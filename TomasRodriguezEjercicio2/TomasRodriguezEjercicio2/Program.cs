using System;

namespace TomasRodriguezEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que determina el tipo de triangulo segun sus lados ");
            Console.WriteLine("Ingrese el lado 1: ");
            int lado1;
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2: ");
            int lado2;
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3: ");
            int lado3;
            lado3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Los lados son {0},{1} y {2}", lado1, lado2, lado3);

            if (lado1 == lado2 ^ lado1 == lado2 ^ lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilatero");
            }
            else if ((lado1 != lado2) ^ (lado1 != lado3) ^ (lado2 != lado3))
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }
            Console.ReadLine();
        }

        private static bool EsTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2;
        }
    }
    ¿
}
