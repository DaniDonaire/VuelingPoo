using System;
using TechTalk.SpecFlow;
using PooVueling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.SpecFlow.Unit.SpecFlow.Test
{
    [Binding]
    public class CalculatorSteps
    {

        private int result;
        private readonly Calculadora calc = new Calculadora();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calc.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calc.SecondNumber = number;
        }

        [When(@"I press (.*)")]
        public void WhenIPressSuma()
        {
            result = calc.Suma(calc.FirstNumber, calc.SecondNumber);
            
        }

        [When(@"I press (.*)")]
        public void WhenIPressResta()
        {
            result = calc.Resta(calc.FirstNumber, calc.SecondNumber);

        }


        [When(@"I press (.*)")]
        public void WhenIPressMultiplicacion()
        {
            result = calc.Multiplicacion(calc.FirstNumber, calc.SecondNumber);

        }


        [When(@"I press (.*)")]
        public void WhenIPressDivision()
        {
            result = calc.Division(calc.FirstNumber, calc.SecondNumber);

        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
