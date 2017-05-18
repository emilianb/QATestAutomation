namespace TestSamples.StepArgumentTransformation
{
    using Microsoft.VisualBasic;
    using System.Linq;
    using TechTalk.SpecFlow;

    [Binding]
    public class CalculatorStepArgumentTransformation
    {
        [StepArgumentTransformation(@"entered (.*) into")]
        public char[] EnterValueArgumentTransform(string value)
        {
            // if the value is a string defining a digit then convert and return it
            switch (value)
            {
                case "one":
                    return new char[] { '1' };
                case "two":
                    return new char[] { '2' };
                case "three":
                    return new char[] { '3' };
                default:
                    return value.ToCharArray();
            }
        }

        [StepArgumentTransformation(@"pressed the (.*) key")]
        [StepArgumentTransformation(@"press the (.*) key")]
        public char[] PressKeyArgumentTransform(string value)
        {
            // if the value is a string defining the key then convert and return it
            switch (value)
            {
                case "plus":
                    return new char[] { '+' };
                case "minus":
                    return new char[] { '-' };
                case "multiply":
                    return new char[] { '+' };
                case "divide":
                    return new char[] { '/' };
                case "equal":
                    return new char[] { '=' };
                default:
                    return value.ToCharArray();
            }
        }
    }
}
