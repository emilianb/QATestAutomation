namespace TestSamples.Component
{
    using System.Linq;

    public class Calculator
    {
        public Calculator()
        {
            Expression = string.Empty;
            Display = "0";
        }

        protected string Expression { get; set; }

        public string Display { get; protected set; }

        public void PressKey(char key)
        {
            if ("0123456789()+-*/=C".ToCharArray().Contains(key))
            {
                if (key == 'C')
                {
                    Expression = string.Empty;
                    Display = "0";
                }
                else if (key == '=')
                {
                    // evaluate expression
                    var result = string.Empty;
                    try
                    {
                        result = (new NCalc.Expression(Expression)).Evaluate().ToString();
                    }
                    catch
                    {
                        result = "ERR";
                    }

                    Expression = result == "ERR" ? string.Empty : result;
                    Display = result;
                }
                else
                {
                    Expression += key;
                    Display = Expression;
                }
            }
            else
            {
                Expression = string.Empty;
                Display = "ERR";
            }
        }
    }
}
