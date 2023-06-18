namespace FibonacciRecursive
{
    internal class Program
    {
        public  delegate int FactorialMethodDelegate(int x);
        public static FactorialMethodDelegate FactorialMethoddelegate = FactorialMethods(number);
        public static int FactorialMethods(int number)
        {
            if (number == 1 || number == 0) return 1;
            return number * FactorialMethods(number - 1);
        }
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FactorialMethoddelegate(a));

        }



        

    }
}