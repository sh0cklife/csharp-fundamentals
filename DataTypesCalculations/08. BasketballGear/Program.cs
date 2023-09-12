namespace _08._BasketballGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double sneakers = trainingFee - (trainingFee * 0.4);
            double team = sneakers - (sneakers * 0.2);
            double ball = team * 0.25;
            double accs = ball * 0.2;
            double total = trainingFee + sneakers + ball + accs + team;

            Console.WriteLine(total);

        }
    }
}