using System;
using VuelingPoo;

namespace PooVueling
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            ///Main Class
            Console.WriteLine("Bienvenido al programa de consola de Dani");

            //Cojemos 3 numeros y los ponemos en boxing
            object nums;
            Box box = new Box();
            nums = box.Boxing();

            Calculadora Calc = new Calculadora();
            Calc.Division(9, 0);

            //Los ordenamos con el metodo de extension
            Extension ext = new Extension();
            ext.Ext(nums);

           
            Console.WriteLine("Pulsa intro para salir");

            Console.ReadLine();

            Environment.Exit(0);

        }
    }
}
