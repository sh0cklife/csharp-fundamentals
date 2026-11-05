namespace _05._Number_In_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool range = num >= 1 && num <= 100;

            while (!range)
            {
                num = int.Parse(Console.ReadLine());
                range = num >= 1 && num <= 100;
            }
            Console.WriteLine(num);
        }
    }
}