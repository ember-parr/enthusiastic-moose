using System;

namespace EnthusiasticCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Cat Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();


            // let the cat speak!
            CatSays("H I, I'M  E N T H U S I A S T I C !");
            // CatSays("I really am enthusiastic");
            Questions();
        }

        static void CatSays(string message)
        {
            Console.WriteLine($@"
   |\---/|
   | ,_, |
    \_`_/-..----.
 ___/ `   ' ,""+ \          {message}
(__...'   __\    |`.___.';
  (_,...'(_,.`__)/'.....+
            ");
        }

        static string CatAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            // while (answer != "y" && answer != "n")
            // {
            //     Console.Write($"{question} (Y/N): ");
            //     answer = Console.ReadLine().ToLower();
            // }


            // while (Console.ReadKey().Key == ConsoleKey.Enter)
            // {
            //     System.Environment.Exit(0);
            // }

            if (answer == "y")
            {
                return "yes";
            }
            else if (answer == "n")
            {
                return "no";
            }
            else if (answer.Length < 1)
            {
                return "close";
            }
            else
            {
                return "what";
            }
        }


        static void Questions()
        {

            Random r = new Random();
            int getNumber = r.Next(1, 20);
            // if (Console.ReadKey().Key == ConsoleKey.Enter)
            // {
            //     System.Environment.Exit(0);
            // }
            string wantToSeeMagic = CatAsks("Do you want to shake the magic cat ball?");
            if (wantToSeeMagic == "yes")
            {
                MagicCat(getNumber);
            }
            else if (wantToSeeMagic == "no")
            {
                CatSays("Well fine then... rude!");
            }
            else if (wantToSeeMagic == "close")
            {
                System.Environment.Exit(0);
            }

            // bool isTrue = CatAsks("Are dogs real?");
            // if (isTrue)
            // {
            //     CatSays("Really? It seems very unlikely.");
            // }
            // else
            // {
            //     CatSays("I  K N E W  I T !!!");
            // }

            // bool isEnthusiastic = CatAsks("Do You Like Catnip?");
            // if (isEnthusiastic)
            // {
            //     CatSays("Yay!");
            // }
            // else
            // {
            //     CatSays("You should try it!");
            // }

            // bool doesLoveCSharp = CatAsks("Do you love C# yet?");
            // if (doesLoveCSharp)
            // {
            //     CatSays("Good job sucking up to your instructor!");
            // }
            // else
            // {
            //     CatSays("You will...oh, yes, you will...");
            // }

            // bool isEverythingFine = CatAsks("Do you want to know a secret?");
            // if (isEverythingFine)
            // {
            //     CatSays("ME TOO!!!! I love secrets...tell me one!");
            // }
            // else
            // {
            //     CatSays("Oh, no...secrets are the best, I love to share them!");
            // }
        }


        static void MagicCat(int randomNumber)
        {
            if (randomNumber == 1)
            {
                CatSays("As I see it, yes.");
            }
            if (randomNumber == 2)
            {
                CatSays("Ask again later.");
            }
            if (randomNumber == 3)
            {
                CatSays("Better not tell you now");
            }
            if (randomNumber == 4)
            {
                CatSays("Cannot predict now");
            }
            if (randomNumber == 5)
            {
                CatSays("Concentrate and ask again");
            }
            if (randomNumber == 6)
            {
                CatSays("Don't count on it");
            }
            if (randomNumber == 7)
            {
                CatSays("It is certain");
            }
            if (randomNumber == 8)
            {
                CatSays("It is decidedly so");
            }
            if (randomNumber == 9)
            {
                CatSays("Most likely");
            }
            if (randomNumber == 10)
            {
                CatSays("My reply is no");
            }
            if (randomNumber == 11)
            {
                CatSays("My sources say no");
            }
            if (randomNumber == 12)
            {
                CatSays("Outlook not so good");
            }
            if (randomNumber == 13)
            {
                CatSays("Outlook good");
            }
            if (randomNumber == 14)
            {
                CatSays("Reply hazy, try again");
            }
            if (randomNumber == 15)
            {
                CatSays("signs point to yes");
            }
            if (randomNumber == 16)
            {
                CatSays("very doubtful");
            }
            if (randomNumber == 17)
            {
                CatSays("Yes!");
            }
            if (randomNumber == 18)
            {
                CatSays("Without a doubt");
            }
            if (randomNumber == 19)
            {
                CatSays("Yes - Definitely");
            }
            if (randomNumber == 20)
            {
                CatSays("You may rely on it");
            }
            Questions();

        }
    }
}