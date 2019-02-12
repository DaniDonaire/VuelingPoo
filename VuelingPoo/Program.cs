using System;
using VuelingPoo;

namespace PooVueling
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            Box box = new Box();

            ///Main Class
            Console.WriteLine("Bienvenido al programa de consola de Dani");

            //Cojemos 3 numeros y los ponemos en boxing
            object nums = box.Boxing();

            //Enviar email por log
            Calc.Main();
            Console.ReadLine();


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
