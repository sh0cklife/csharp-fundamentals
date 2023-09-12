using System.Diagnostics.Contracts;

namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int crafstmenHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = paint * 1.1 * 14.50;
            double thinnerPrice = thinner * 5;

            double totalMats = nylonPrice + paintPrice + thinnerPrice + 0.40;
            double craftsmenHourPrice = totalMats * 0.3;
            double grandTotal = totalMats + craftsmenHourPrice * crafstmenHours;

            Console.WriteLine(grandTotal);

        }
    }
}