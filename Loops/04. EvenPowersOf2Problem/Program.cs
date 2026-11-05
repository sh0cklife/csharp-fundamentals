namespace _04._EvenPowersOf2Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= num; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}