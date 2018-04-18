using System;
using System.Runtime.InteropServices;

namespace ConsoleAppExample
{
    class Program
    {
        [DllImport(@"C:\Users\Marvin Castillo\source\repos\ExampleForDLL\x64\Debug\ExampleForDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);
        [DllImport(@"C:\Users\Marvin Castillo\source\repos\ExampleForDLL\x64\Debug\ExampleForDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Multiply(double a, double b);
        [DllImport(@"C:\Users\Marvin Castillo\source\repos\ExampleForDLL\x64\Debug\ExampleForDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double AddMultiply(double a, double b);
        [DllImport(@"C:\Users\Marvin Castillo\source\repos\ExampleForDLL\x64\Debug\ExampleForDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Count(string text);
        static void Main(string[] args)
        {
            var text = "1234567890";
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Add: {Add(7, 7)}");
            Console.WriteLine($"Multiply: {Multiply(4, 4)}");
            Console.WriteLine($"AddMultiply: {AddMultiply(3, 3)}");
            Console.WriteLine($"Lenght: {Count(text)}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
