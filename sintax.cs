using System;

namespace Parte1{
    class sintaxASD{
        public void explicita() {
            float flo = 23.4F;
            int ent = (int)flo;
            Console.WriteLine($"ent is: {ent}");
        }
        public void implicita() {
            int ent = 23;
            double dou = ent;
            Console.WriteLine($"dou is: {dou}");
        }
        public void constAndImput() {
            const double PI = 3.1416;
            Console.WriteLine("Insert the diametro: ");
            double diametro = double.Parse(Console.ReadLine()!);
            double area1 = diametro * diametro * PI;
            Console.WriteLine($"The area is: {area1}");
        }

    }
} 