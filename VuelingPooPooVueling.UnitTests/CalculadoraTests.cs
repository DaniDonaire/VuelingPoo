using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PooVueling.Unit.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        private ICalculadora mockObject;


        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<ICalculadora>();
            mock.Setup(x => x.Suma(2, 2)).Returns(4);
            mock.Setup(x => x.Resta(2, 2)).Returns(0);
            mock.Setup(x => x.Multiplicacion(2, 2)).Returns(4);
            mock.Setup(x => x.Division(2, 2)).Returns(1);
            mock.Setup(x => x.Division(2, 0)).Throws<DivideByZeroException>();
            mockObject = mock.Object;

        }


        //Test Moq
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceptionTest()
        {
            var result = mockObject.Division(2, 0);
            //Assert.AreEqual(1, result);
            //Assert.Fail();
        }
        //Test Moq
        [TestMethod()]
        public void DivisionTest()
        {
            var result = mockObject.Division(2, 2);
            Assert.AreEqual(1, result);
        }
        //Test Moq
        [TestMethod()]
        public void MultiplicacionTest()
        {
            var result = mockObject.Multiplicacion(2, 2);
            Assert.AreEqual(4, result);
        }
        //Test Moq
        [TestMethod()]
        public void RestaTest()
        {
            var result = mockObject.Resta(2, 2);
            Assert.AreEqual(0, result);
        }
        //Test Moq
        [TestMethod()]
        public void SumaTest()
        {
            var result = mockObject.Suma(2, 2);
            Assert.AreEqual(4, result);
        }


    }
}