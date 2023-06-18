

namespace FibonacciRecursive
{
    internal class Program
    {
        public delegate int FactorialMethodDelegate(int number);

        public static int FactorialMethods(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            return number * FactorialMethods(number - 1);
        }

        static void Main(string[] args)
        {
            FactorialMethodDelegate factorialDelegate = FactorialMethods;
            Console.WriteLine(factorialDelegate(Convert.ToInt32(Console.ReadLine())));
        }
    }
}

