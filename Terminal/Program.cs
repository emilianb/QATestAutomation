namespace Terminal
{
    using System;
    using TestSamples.Component;

    public class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Display: {0}", calc.Display);

            calc.PressKey('1');
            calc.PressKey('+');
            calc.PressKey('1');

            Console.WriteLine("Display: {0}", calc.Display);

            calc.PressKey('=');

            Console.WriteLine("Display: {0}", calc.Display);

            calc.PressKey('C');

            Console.WriteLine("Display: {0}", calc.Display);

            Console.WriteLine("press any key to continue...");
            Console.Read();
        }
    }
}
