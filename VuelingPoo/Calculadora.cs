﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public class Calculadora : ICalculadora, ICloneable
    {

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly log4net.ILog logCalculadora = log4net.LogManager.GetLogger(typeof(Calculadora).DeclaringType);

        public void Main()
        {
            log.Info("Hello logging world!");
            Console.WriteLine("Hit enter");
        }

        public object Clone()
        {
            throw new NotImplementedException("El metodo no esta implementado aun");
        }

        public int Division(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                log.Info("Dividiendo entre 0! ", e);
                Console.WriteLine(e.Message);
                //Console.ReadLine();
                throw;
            }
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1*num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1-num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1+num2;
        }
    }
}
