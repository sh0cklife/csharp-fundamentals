namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    // CODE HERE
            //    Console.WriteLine(i);

            //string text = "SoftUni";
            //Console.WriteLine(text.Length);

            //Console.WriteLine(text[4]);

            //string text = Console.ReadLine();
            //int vowelWeight = 0;

            //for (int i = 0; i < text.Length; i +=1)
            //{
            //    char myChar = text[i];
            //    if (myChar == 'a')
            //    {
            //        vowelWeight += 1;
            //    }else if (myChar == 'e')
            //    {
            //        vowelWeight += 2;
            //    }else if(myChar =='i')
            //    {
            //        vowelWeight += 3;
            //    }
            //    else if (myChar == 'o')
            //    {
            //        vowelWeight += 4;
            //    }
            //    else if (myChar == 'u')
            //    {
            //        vowelWeight += 5;
            //    }
            //}
            //Console.WriteLine(vowelWeight); da se dopishe pravilno

            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome: {username}!");

        }
        
    }
}