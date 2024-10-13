using System;

namespace KASDLab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReversePolishNotation rpn = new ReversePolishNotation();

            Console.WriteLine(rpn.Convert("3 + 8 * 7 - 1 - sin5"));

            Console.ReadKey();
        }
    }
}
