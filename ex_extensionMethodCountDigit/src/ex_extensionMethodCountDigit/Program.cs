using System;


namespace ex_extensionMethodCountDigit
{
    static class Program
    {
        static void Main(string[] args)
        {
            int num1 = 35634;
            int result = num1.getDigit();
            int r = 344.getDigit();   //extension method....
            Console.WriteLine(result+"   "+ r);
        }
    }
}
