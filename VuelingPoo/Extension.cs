using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Extension
    {

        public void Ext()
        {
            //Proximamente puedo pedir numeros en un boxing y puedo sacarlos haciendo unboxing
            System.Console.Write("Ordenando; ");
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }

        }

    }
}
