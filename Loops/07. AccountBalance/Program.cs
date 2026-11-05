namespace _07._AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "NoMoreMoney")
                {
                    break;
                }

                double amount = double.Parse(command);
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += amount;
                Console.WriteLine($"Increase: {amount:f2}");

            }
            Console.WriteLine($"Total: {total:f2}");
            
        }
    }
}