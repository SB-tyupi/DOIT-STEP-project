namespace DOIT_Project2
{
    /*
     Game: Hangman
    program shall choose random word predifined in list
    and display underscores amount of letters in the secret word.
    user shall guess the letter and if the letter is in the secret word,
    it shall reveal the the letter in correct place.
    */
    internal class Program
    {
        public static void visual(int guess)
        {
            switch (guess)
            {
                case 1:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |\r\n |\r\n |_______\r\n");
                    break;
                    case 2:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |     ||\r\n |\r\n |_______\r\n");
                    break;
                    case 3:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |    /||\r\n |\r\n |_______\r\n");
                    break;
                    case 4:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |    /||\\\r\n |\r\n |_______\r\n");
                    break;
                    case 5:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |    /||\\\r\n |     /\r\n |_______\r\n");
                    break;
                    case 6:
                    Console.WriteLine(" _______\r\n |     \\\r\n |     () \r\n |    /||\\\r\n |     /\\\r\n |_______\r\n");
                    break;
            }
        }

        //public static void checkChar(char ch, char[] word, string str)
        //{
        //    int count = 0;
        //    //adds letters in correct spot
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if(ch == str[i])
        //        {
        //            word[i] = ch;
        //            count++;
        //        }
        //        if (count == str.Length)
        //        {
        //            Console.WriteLine("Congrats! You have won the game!");
        //        }
        //    }
        //    for (int i = 0;i < str.Length;i++)
        //    {
        //        Console.Write(word[i]);
        //    }
        //    Console.WriteLine();
        //}

        
        static void Main(string[] args)
        {
            Console.WriteLine("This is the game HANGMAN! " +
                "\nProgram will choose random word and you have to guess letters!");
            List<string> word = new List<string> {"money", "car", "computer", "step", "phone",
                "program", "air", "factory", "positive" };

            Random random = new Random();

            int rand = random.Next(word.Count);

            string secret_word = word[rand];
            char[] sWord_arr = new char[secret_word.Length];
            //fills array with underscores
            for (int i = 0; i < secret_word.Length; i++)
            {
                sWord_arr[i] = '_';
            }

            Console.WriteLine("Try not to hang the stickman like this!!");
            visual(6);



            int count = 0;
            int wrong_guess = 0;
            int count_guess = 0;
            try { 
            while (count != secret_word.Length)
            {
                char guess = char.Parse(Console.ReadLine());
            if (guess == 0)
            {
                break;
            }
                
                //adds letters in correct spot
                for (int i = 0; i < secret_word.Length; i++)
                {
                    if (guess == secret_word[i])
                    {
                        sWord_arr[i] = guess;
                        count++;
                        count_guess++;
                    }
                }
                
                //visual part of the program (the stickman)
                if (count_guess == 0)
                {
                    wrong_guess++;
                    visual(wrong_guess);
                    if (wrong_guess == 6)
                    {
                        Console.WriteLine("You have lost the game :((");
                        break;
                    }
                }
                else
                {
                    visual(wrong_guess);
                    count_guess = 0;
                }

                //prints out the secret word
                for (int i = 0; i < secret_word.Length; i++)
                {
                    Console.Write(sWord_arr[i]);
                }
                Console.WriteLine();

                if (count == secret_word.Length)
                {
                    Console.WriteLine("Congrats! You have won the game!");
                }

            }

            }catch (Exception e)
            {
                Console.WriteLine("Error happend: " + e.Message);
            }





        }
    }
}
