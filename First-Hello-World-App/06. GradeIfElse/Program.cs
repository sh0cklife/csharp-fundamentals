namespace _06._GradeIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade <= 5.5)
            {
                Console.WriteLine("Not Excellent.");
            }
            else
            {
                Console.WriteLine("Excellent!");
            }
        }    
    }
}