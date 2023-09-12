namespace _04._MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int ppH = int.Parse(Console.ReadLine());
            int readingDays = int.Parse(Console.ReadLine());

            int hourForTheBook = pages / ppH; // the number of hours we need to read the book
            int hoursReadingPerDay = hourForTheBook / readingDays;

            Console.WriteLine(hoursReadingPerDay);
            

        }
    }
}