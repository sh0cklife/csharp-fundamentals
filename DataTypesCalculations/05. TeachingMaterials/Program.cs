namespace _05._TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markerPacks = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penPrice = penPacks * 5.80;
            double markerPrice = markerPacks * 7.20;
            double boardCleanerPrice = boardCleaner * 1.20;
            double totalPrice = penPrice + markerPrice + boardCleanerPrice;
            double discountAmount = totalPrice * discount / 100;
            double neededMoney = totalPrice - discountAmount;

            // Console.WriteLine("Normal Price: " + totalPrice);
            // Console.WriteLine("Discounted Price: " + neededMoney);
            
            Console.WriteLine(neededMoney);
        }
    }
}