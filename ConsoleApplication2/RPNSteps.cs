using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApplication2
{
    [Binding]
    public class RPNSteps
    {
        string expr;

        [Given(@"user enter ""(.*)""")]
        public void GivenUserEnter(string p0)
        {
            //ScenarioContext.Current.Pending();
            expr = p0;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //ScenarioContext.Current.Pending();
            RPNCalculator calc = new RPNCalculator();

            Assert.AreEqual(p0, calc.CalculateRPN(expr));
        }
    }
}
