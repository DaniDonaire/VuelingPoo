using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Box
    {

        public object Boxing()
        {
            int veces = 3;
            String texto;
            int[] ints = new int[veces];

            for (var num = 0; num < veces; num++)
            {
                Console.WriteLine("\nDame el numero {0}:", (num+1));
                texto = Console.ReadLine();
                Int32.TryParse(texto, out ints[num]);
            }

            object o = ints;
            return o;
        }

        public int[] Unboxing(object nums)
        {
            throw new NotImplementedException("Aun no esta implementado");
           
        }
    }
}

