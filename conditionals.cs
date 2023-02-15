using System;

namespace Parte1
{
    class conditionalsASD
    {
        public void if1()
        {
            Console.WriteLine("What is you age?");
            int age1 = int.Parse(Console.ReadLine()!);

            if (age1 >= 18)
            {
                Console.WriteLine("Imput category: premium or standar?");
                string imput1 = Console.ReadLine()!;
                if (imput1 == "premium")
                {
                    Console.WriteLine("You pass.");
                    Console.WriteLine("Welcome.");
                }
                else if (imput1 == "standar")
                    Console.WriteLine("You wait.");
                else
                    Console.WriteLine("Error.");
            }
            else if (age1 < 18)
            {
                Console.WriteLine("You come with an adult? (yes or no).");
                string adult1 = Console.ReadLine()!;
                if (adult1 == "yes")
                    Console.WriteLine("Wait in the line.");
                else if (adult1 == "no")
                    Console.WriteLine("You can not pass.");
                else
                    Console.WriteLine("Error.");
            }
            else
                Console.WriteLine("Error.");
        }

        public void switch1()
        {
            Console.WriteLine("What is the month of my birthday?.");
            string age1 = Console.ReadLine()!;

            switch (age1)
            {
                case "January":
                    Console.WriteLine("No");
                    break;
                case "February":
                    Console.WriteLine("No");
                    break;
                case "March":
                    Console.WriteLine("No");
                    break;
                case "April":
                    Console.WriteLine("Yes");
                    break;
                case "May":
                    Console.WriteLine("No");
                    break;
                case "June":
                    Console.WriteLine("No");
                    break;
                case "July":
                    Console.WriteLine("No");
                    break;
                case "August":
                    Console.WriteLine("No");
                    break;
                case "September":
                    Console.WriteLine("No");
                    break;
                case "Octuber":
                    Console.WriteLine("No");
                    break;
                case "November":
                    Console.WriteLine("No");
                    break;
                case "December":
                    Console.WriteLine("No");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
