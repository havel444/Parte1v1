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







        public void Password02()
        {
            string Access = ComboString("You want participate? (yes or no).");
            int Point = 0;

            while(Access == "yes" && Point < 3)
            {
                Point += 1;
                TextString($"Attempt {Point}/3");
                
                int UserPassword = int.Parse(ComboString("Insert your password."));

                if(Point == 3)
                {
                    TextString("Excess attempts.");
                    
                }
                else if(UserPassword == 1234)
                {
                    TextString("Wellcome.");
                }
                else if(UserPassword != 1234)
                {
                    TextString("Incorrect password.");
                }
                else
                {
                    TextString("ERROR.");
                }
            }
            TextString("Finish.");


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
