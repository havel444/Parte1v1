using Parte1;
using Parte1.Message;

namespace Parte1
{
    class Program
    {
        static void Main(string[] arg)
        {
            // Console.WriteLine("Ingrese el nombre");
            // var nombre = Console.ReadLine()!;
            // Console.WriteLine("Ingrese el password");
            // var password = Console.ReadLine()!;
            // Console.WriteLine(Logger(nombre, password));

            var ki1 = new sintaxASD();
            //ki1.explicita();
            //implicita();
            //constAndImput();
            //methodsASD();

            var ki2 = new methodsASD();
            //Console.WriteLine(ki2.parameters1("Alan", "Torres"));
            //ki2.ambit1();
            //Console.WriteLine(ki2.sobre1(4, 3.3));
            //Console.WriteLine(ki2.option1(1, 1, 1));

            var ki3 = new conditionalsASD();
            // ki3.if1();
            // ki3.switch1();

            var ki4 = new bucleASD();
            // ki4.While();
            // ki4.Password();
            ki4.Password02();

            // var (valor1, valor2) = MaxMin();
            // Console.WriteLine(valor1);

            // TODO Instancias: programacion orientada a objetos. //
        }

        // public static(int, int) MaxMin()
        // {

        //     return (12,20);
        // }


        // public static string Logger(string name, string password)
        // {
        //     var us1 = new Usuarios();
        //     Alumnos? alumnos = us1.alumnos.FirstOrDefault(
        //         x => x.Name == name && x.Password == password
        //     )!;
        //     if (alumnos == null)
        //         return TypeMessage.Error;
        //     return TypeMessage.Login;
        // }
    }
}
