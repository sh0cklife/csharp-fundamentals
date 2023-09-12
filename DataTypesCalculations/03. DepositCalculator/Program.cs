namespace _03._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            double amount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double final = amount + months * (amount * (interest/100.0)) / 12;

            Console.WriteLine(final);


        }
    }
}