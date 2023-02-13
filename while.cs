using System;


namespace cshard {
    class bucleASD {
        public void while1() {

            Console.WriteLine("You want to participate in the raflle? (yes or no).");
            string raflle = Console.ReadLine();

            while (raflle == "yes") {

                Console.WriteLine("insert a number:");
                int date1 = int.Parse(Console.ReadLine());


                Random numero1 = new Random();
                int alazar = numero1.Next(1, 10);
                Console.WriteLine(alazar);

                if (alazar == date1) {
                    Console.WriteLine($"Congratulations, you won. Do you want to try again? (yes or no).");
                    raflle = Console.ReadLine();
                }
                else if (alazar != date1) {
                    Console.WriteLine("You lost. Do you want to try again? (yes or no).");
                    raflle = Console.ReadLine();
                }
                else Console.WriteLine("Error");
            }

            switch (raflle) {
                case "no": Console.WriteLine("Finish");
                break;
                default: Console.WriteLine("Error");
                break;
            }


        }


        // ---------------------------------------------------
        public 



    }
}