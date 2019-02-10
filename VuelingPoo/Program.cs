using System;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Main Class
            ///

            Console.WriteLine("Introduzca un texto");
            String texto;
            texto = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + texto);

            Extension ext = new Extension();
            ext.Ext();

            Console.WriteLine("Pulsa intro para salir");
            texto = Console.ReadLine();

            Environment.Exit(0);

        }
    }
}
