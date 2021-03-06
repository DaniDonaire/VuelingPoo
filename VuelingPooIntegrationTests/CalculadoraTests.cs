﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        //Para utilizar sus metodos a traves de la variable (Polimorfismo)
        ICalculadora iCalculadora = new Calculadora();

        
        //Test de TestFramework de Visual Studio
        [DataRow(4, 2, 2)]
        [DataRow(9, 3, 3)]
        [DataTestMethod()]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) ==
                resultado);

        }

        //Test Exception
        [DataRow(9, 0, 0)]
        [DataTestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionDivideByZeroExceptionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) ==
                resultado);

        }

        //Test visual
        [DataRow(4, 2, 8)]
        [DataRow(9, 3, 27)]
        [DataRow(7, 1, 7)]
        [DataTestMethod()]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) ==
                resultado);

            //Assert.Fail();
        }

        //Test visual
        [DataRow(4, 2, 2)]
        [DataRow(9, 3, 6)]
        [DataRow(7, 1, 6)]
        [DataTestMethod()]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) ==
                resultado);

            //Assert.Fail();
        }


        //Test visual
        [DataRow(4, 2, 6)]
        [DataRow(9, 3, 12)]
        [DataRow(7, 1, 8)]
        [DataTestMethod()]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) ==
               resultado);

            //Assert.Fail();
        }
    }
}