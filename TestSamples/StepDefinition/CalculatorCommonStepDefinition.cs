namespace TestSamples.StepDefinition
{
    using Component;
    using FluentAssertions;
    using System.Linq;
    using TechTalk.SpecFlow;

    [Binding]
    public class CalculatorCommonStepDefinition : Steps
    {
        [Given(@"I have a calculator")]
        public void CreateCalculator()
        {
            // create calculator instance
            var calculator = new Calculator();

            // retrieve curent scenario context
            var context = ScenarioContext.Current;
            context.Add("Calculator", calculator);
        }

        [Given(@"I have (entered .* into) the calculator")]
        [Given(@"I have (pressed the .* key)")]
        [When(@"I (press the .* key)")]
        public void ProvideInputToCalculator(char[] value)
        {
            // retrieve current scenario context
            var context = ScenarioContext.Current;

            // retrieve calculator instance from context
            var calculator = context.Get<Calculator>("Calculator");

            // enter value into calculator
            value.ToList().ForEach(key => calculator.PressKey(key));
        }

        [Then(@"the result on the screen should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedOutput)
        {
            // retrieve current scenario context
            var context = ScenarioContext.Current;

            // retrieve calculator instance from context
            var calculator = context.Get<Calculator>("Calculator");

            // retrieve actual output
            var actualOutput = calculator.Display;

            // Verify expectations
            actualOutput.Should().Be(expectedOutput);
        }
    }
}
