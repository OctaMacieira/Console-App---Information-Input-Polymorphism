using System;
using System.Globalization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist;
            double gas, medCons;

            Console.WriteLine("Insira a distância percorrida: ");
            dist = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o consumo de gasolina em litros: ");
            gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            medCons = (double) dist / gas;

            Console.WriteLine(medCons.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
