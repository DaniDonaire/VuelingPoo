using System;
using VuelingPoo;

namespace PooVueling
{
    public class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {
            log.Info("Hello dani! Ree");
            Console.WriteLine("Hit enter");
            Console.ReadLine();

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

            Console.ReadLine();

            Environment.Exit(0);

        }
    }
}
