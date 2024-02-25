using System.Text;

namespace DOIT_Project1
{
    /*
     Georgian Letter Translator

    translates english word to georgian words
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the text and this program will tranform your words into Georigian alphabet!");
            Console.OutputEncoding = Encoding.UTF8;
            input = Console.ReadLine();

            char[] text = new char[input.Length];

            for (int i = 0; i < text.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        text[i] = 'ა';
                        break;
                    case 'b':
                        text[i] = 'ბ';
                        break;
                    case 'c':
                        text[i] = 'ც';
                        break;
                    case 'C':
                        text[i] = 'ჩ';
                        break;
                    case 'd':
                        text[i] = 'დ';
                        break;
                    case 'e':
                        text[i] = 'ე';
                        break;
                    case 'f':
                        text[i] = 'ფ';
                        break;
                    case 'g':
                        text[i] = 'გ';
                        break;
                    case 'h':
                        text[i] = 'ჰ';
                        break;
                    case 'i':
                        text[i] = 'ი';
                        break;
                    case 'j':
                        text[i] = 'ჯ';
                        break;
                    case 'J':
                        text[i] = 'ჟ';
                        break;
                    case 'k':
                        text[i] = 'კ';
                        break;
                    case 'l':
                        text[i] = 'ლ';
                        break;
                    case 'm':
                        text[i] = 'მ';
                        break;
                    case 'n':
                        text[i] = 'ნ';
                        break;
                    case 'o':
                        text[i] = 'ო';
                        break;
                    case 'p':
                        text[i] = 'პ';
                        break;
                    case 'q':
                        text[i] = 'ქ';
                        break;
                    case 'r':
                        text[i] = 'რ';
                        break;
                    case 'R':
                        text[i] = 'ღ';
                        break;
                    case 's':
                        text[i] = 'ს';
                        break;
                    case 'S':
                        text[i] = 'შ';
                        break;
                    case 't':
                        text[i] = 'ტ';
                        break;
                    case 'T':
                        text[i] = 'თ';
                        break;
                    case 'u':
                        text[i] = 'უ';
                        break;
                    case 'v':
                        text[i] = 'ვ';
                        break;
                    case 'w':
                        text[i] = 'წ';
                        break;
                    case 'W':
                        text[i] = 'ჭ';
                        break;
                    case 'x':
                        text[i] = 'ხ';
                        break;
                    case 'y':
                        text[i] = 'ყ';
                        break;
                    case 'z':
                        text[i] = 'ზ';
                        break;
                    case 'Z':
                        text[i] = 'ძ';
                        break;
                    case ' ':
                        text[i] = ' ';
                        break;
                    default:
                        text[i] = '?';
                        break;

                }
                Console.Write(text[i]);
            }
        }
    }
}
