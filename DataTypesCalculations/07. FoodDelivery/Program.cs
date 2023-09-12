namespace _07._FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double vegPrice = vegMenu * 8.15;

            double totalMenuPrice = chickenPrice + fishPrice + vegPrice;
            double dessertPrice = totalMenuPrice * 0.2;
            double deliveryPrice = 2.50;
            double grandTotal = totalMenuPrice + dessertPrice + deliveryPrice;

            Console.WriteLine(grandTotal);


        }
    }
}