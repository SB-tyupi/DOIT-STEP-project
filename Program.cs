namespace DOIT_Project
{
    /*
     Guess the Number
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rand = random.Next(1, 100);
            Console.WriteLine("Program chose number randomly in range of 1 to 100" +
                " \n your mission is to find that number!");
            Console.WriteLine("If you want to quit write -1");
            int quit = -1;
            int count = 0;

            try
            {
                int guess = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (guess > rand)
                    {
                        Console.WriteLine("Try lower number");
                        guess = int.Parse(Console.ReadLine());
                        count++;
                    }
                    else if (guess < rand)
                    {
                        Console.WriteLine("Try higher number");
                        guess = int.Parse(Console.ReadLine());
                        count++;
                    }
                    else if (guess == rand)
                    {
                        Console.WriteLine($"You guessed the number in {count} tries");
                        break;
                    }
                    else if (guess == -1)
                    {
                        Console.WriteLine("you failed");
                        break;
                    }


                }
            } catch(Exception e) 
            {
                Console.WriteLine("The error was: " + e.Message);
            }
        }
    }
}
