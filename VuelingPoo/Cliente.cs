﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingPoo
{
    class Cliente : IDisposable
    {
        public string Nombre { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
