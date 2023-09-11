namespace _11._AnimalTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile": Console.WriteLine("reptile"); break;
                case "tourtouise": Console.WriteLine("reptile"); break;
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("Unknown"); break;
            }

        }
    }
}