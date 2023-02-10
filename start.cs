using System;

        // conversion explicita
        // conversion implicita
        // cosnt e imput

        // parametros, argumentos y return
        // ambito
        // sobre carga y parametros opcionales

        // condicionales if, else if y else + && y ||
        // swich

        // buble while

namespace sintax{
    class Program{
        static void Main(string[] arg) {

            explicita();
            //implicita();


        }

        static void explicita() {
            float flo = 23.4F;
            int ent = (int)flo;
            Console.WriteLine($"ent is: {ent}");
        }
        static void implicita() {
            int ent = 23;
            double dou = ent;
            Console.WriteLine($"dou is: {dou}");
        }



        
    }
}
































