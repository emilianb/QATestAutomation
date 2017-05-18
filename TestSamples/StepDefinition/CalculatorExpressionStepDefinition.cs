namespace TestSamples.StepDefinition
{
    using Model;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class CalculatorExpressionStepDefinition : Steps
    {
        [Given(@"I have entered the following expression in the calculator")]
        public void ProvideInputExpressionToCalculator(Table expressionData)
        {
            // retrieve the expression
            var expression = expressionData.CreateInstance<Expression>();

            // reuse steps

            // enter first value into the calculator
            Given(
                string.Format(
                    @"I have entered {0} into the calculator",
                    expression.FirstValue));

            // enter the operation into calculator
            Given(
                string.Format(
                    @"I have pressed the {0} key",
                    expression.Operation));

            // enter second value into the calculator
            Given(
                string.Format(
                    @"I have entered {0} into the calculator",
                    expression.SecondValue));
        }
    }
}
