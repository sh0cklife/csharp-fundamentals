namespace _02._OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            while (a % 2 == 0) // четно
            {
                a = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(a);
        }
    }
}