namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double liters = length * width * height * 0.001;
            double water = 1 - perc / 100;

            Console.WriteLine(liters * water);

        }
    }
}