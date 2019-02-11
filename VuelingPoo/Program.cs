using System;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Main Class
            Console.WriteLine("Bienvenido al programa de consola de Dani");


            //Cojemos 3 numeros y los ponemos en boxing
            object nums;
            Box box = new Box();
            nums = box.Boxing();

            //Los ordenamos con el metodo de extension
            Extension ext = new Extension();
            ext.Ext(nums);

            Console.WriteLine("Pulsa intro para salir");
            var exit = Console.ReadLine();

            Environment.Exit(0);

        }
    }
}
