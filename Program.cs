using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // MooseSays("H I, I'M  E N T H U S I A S T I C !");
            // MooseSays("I really am enthusiastic");
            Questions();
        }

        static void MooseSays(string message)
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

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Questions()
        {

            Random r = new Random();
            int getNumber = r.Next(1, 20);


            // bool isTrue = MooseAsks("Are dogs real?");
            // if (isTrue)
            // {
            //     MooseSays("Really? It seems very unlikely.");
            // }
            // else
            // {
            //     MooseSays("I  K N E W  I T !!!");
            // }

            // bool isEnthusiastic = MooseAsks("Do You Like Catnip?");
            // if (isEnthusiastic)
            // {
            //     MooseSays("Yay!");
            // }
            // else
            // {
            //     MooseSays("You should try it!");
            // }

            // bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            // if (doesLoveCSharp)
            // {
            //     MooseSays("Good job sucking up to your instructor!");
            // }
            // else
            // {
            //     MooseSays("You will...oh, yes, you will...");
            // }

            // bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            // if (isEverythingFine)
            // {
            //     MooseSays("ME TOO!!!! I love secrets...tell me one!");
            // }
            // else
            // {
            //     MooseSays("Oh, no...secrets are the best, I love to share them!");
            // }

            bool wantToSeeMagic = MooseAsks("Do you want to shake the magic cat ball?");
            if (wantToSeeMagic)
            {
                MagicCat(getNumber);
            }
            else
            {
                MooseSays("Well fine then... rude!");
            }


        }


        static void MagicCat(int randomNumber)
        {
            if (randomNumber == 1)
            {
                MooseSays("As I see it, yes.");
            }
            if (randomNumber == 2)
            {
                MooseSays("Ask again later.");
            }
            if (randomNumber == 3)
            {
                MooseSays("Better not tell you now");
            }
            if (randomNumber == 4)
            {
                MooseSays("Cannot predict now");
            }
            if (randomNumber == 5)
            {
                MooseSays("Concentrate and ask again");
            }
            if (randomNumber == 6)
            {
                MooseSays("Don't count on it");
            }
            if (randomNumber == 7)
            {
                MooseSays("It is certain");
            }
            if (randomNumber == 8)
            {
                MooseSays("It is decidedly so");
            }
            if (randomNumber == 9)
            {
                MooseSays("Most likely");
            }
            if (randomNumber == 10)
            {
                MooseSays("My reply is no");
            }
            if (randomNumber == 11)
            {
                MooseSays("My sources say no");
            }
            if (randomNumber == 12)
            {
                MooseSays("Outlook not so good");
            }
            if (randomNumber == 13)
            {
                MooseSays("Outlook good");
            }
            if (randomNumber == 14)
            {
                MooseSays("Reply hazy, try again");
            }
            if (randomNumber == 15)
            {
                MooseSays("signs point to yes");
            }
            if (randomNumber == 16)
            {
                MooseSays("very doubtful");
            }
            if (randomNumber == 17)
            {
                MooseSays("Yes!");
            }
            if (randomNumber == 18)
            {
                MooseSays("Without a doubt");
            }
            if (randomNumber == 19)
            {
                MooseSays("Yes - Definitely");
            }
            if (randomNumber == 20)
            {
                MooseSays("You may rely on it");
            }

        }
    }
}