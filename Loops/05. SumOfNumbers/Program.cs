namespace _05._SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNmber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < maxNmber)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}