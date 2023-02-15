namespace Parte1
{
    class bucleASD
    {
        public void While()
        {
            Console.WriteLine("You want to participate in the raflle? (yes or no).");
            string raflle = Console.ReadLine()!;
            while (raflle == "yes")
            {
                Console.WriteLine("insert a number:");
                int date1 = int.Parse(Console.ReadLine()!);

                Random numero1 = new Random();
                int alazar = numero1.Next(1, 10);
                Console.WriteLine(alazar);

                if (alazar == date1)
                {
                    Console.WriteLine(
                        $"Congratulations, you won. Do you want to try again? (yes or no)."
                    );
                    raflle = Console.ReadLine()!;
                }
                else if (alazar != date1)
                {
                    Console.WriteLine("You lost. Do you want to try again? (yes or no).");
                    raflle = Console.ReadLine()!;
                }
                else
                    Console.WriteLine("Error");
            }

            switch (raflle)
            {
                case "no":
                    Console.WriteLine("Finish");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        // ---------------------------------------------------
        // public void Password()
        // {
        //     int intentos = 1;
        //     string terminar = "";

        //     while (intentos <= 3 && terminar != "no")
        //     {
        //         Console.WriteLine($"Intento numero {intentos}/3.");

        //         var usuar = Combo1("Inserte el usuario");
        //         var contr = Combo1("Inserte la contraseña");

        //         if (usuar == "alan" && contr == "1234")
        //         {
        //             Console.WriteLine("Bienvenido.");
        //             intentos = 3;
        //         }
        //         else if (intentos == 3)
        //         {
        //             Console.WriteLine("Superaste le maximo de intentos.");
        //         }
        //         else if (usuar != "alan" || contr != "1234")
        //         {
        //             terminar = Combo1(
        //                 "Usuario o constraseña incorrecta. Quiere volver a intentarlo? (si o no)."
        //             );
        //         }
        //         else
        //         {
        //             Console.WriteLine("Error.");
        //         }
        //         intentos++;
        //     }

        //     Console.WriteLine("Finish");
        // }

        // ---------------------------------------------------


        public void Random()
        {
            string Access = ComboString("Do yuo want to participate? (yes or no).");
            int Try = 0;

            while (Access == "yes" && Try < 5)
            {
                Try += 1;
                TextString($"Intent number {Try}/5");

                int Number = int.Parse(ComboString("Insert a number of the 1 to 15."));

                Random Num = new Random();
                int Azar = Num.Next(1, 15);

                if (Try == 5)
                {
                    TextString("You exceeded the maximum number of attempts.");
                }
                else if (Number == Azar)
                {
                    TextString("Congratulations");
                    Access = "no";
                }
                else if (Number < Azar)
                {
                    TextString("Your number is less.");
                }
                else if (Number > Azar)
                {
                    TextString("You number is hisher.");
                }
                else
                    TextString("Error.");
            }
            TextString("FINISH.");
        }




















        public string ComboString(string Message)
        {
            Console.WriteLine(Message);
            string Replay = Console.ReadLine()!;
            return Replay;
        }

        public string TextString(string Message)
        {
            Console.WriteLine(Message);
            return Message;
        }
    }
}
