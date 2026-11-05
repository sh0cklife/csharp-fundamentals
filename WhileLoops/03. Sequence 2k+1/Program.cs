namespace _03._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int sum = 1;

            while (sum <= limit)
            {
                Console.WriteLine(sum);
                sum = sum * 2 + 1;
                
            }
            
        }
    }
}