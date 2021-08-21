using System;

namespace TomasRodriguezEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit, MayorTemperatura;
            double Promedio = 0;

            int CantidadX;

            do
            {
                Console.Write("Ingrese la cantidad de temperaturas a evaluar: ");
                if (!int.TryParse(Console.ReadLine(), out CantidadX))
                {
                    Console.WriteLine("Cantidad mal ingresada");

                }
                else if (CantidadX <= 0 || CantidadX > 20)
                {
                    Console.WriteLine("La cantidad debe ser positiva e inferior o igual a 20");
                }
                else
                {
                    break;
                }
            } while (true);
            MayorTemperatura = -71;
            for (int contador = 0; contador < CantidadX; contador++)
            {
                do
                {
                    Console.Write($"Ingrese la temperatura {contador + 1}:");
                    if (!double.TryParse(Console.ReadLine(), out Celsius))
                    {
                        Console.WriteLine("Cantidad mal ingresada");
                    }
                    else if (Celsius < -70 || Celsius > 60)
                    {
                        Console.WriteLine("La temp debe estar en el rango -70 y 60 grados");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                Fahrenheit = ConvertirFahrenheit(Celsius);
                Console.WriteLine($"{Celsius} equivalen a {Fahrenheit} grados F");
                if (Celsius > MayorTemperatura)
                {
                    MayorTemperatura = Celsius;
                }
                Promedio += Celsius;
            }
            Promedio /= CantidadX;
            Console.WriteLine($"La mayor temperatura es {MayorTemperatura}");
            Console.WriteLine($"La media de temperatura es {Promedio}");
            Console.ReadLine();
        }
        private static double ConvertirFahrenheit(double grados)
        {
            return 1.8 * grados + 32;
        }
    }
}
