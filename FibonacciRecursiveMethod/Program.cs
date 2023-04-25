int FactorialMethod(int number)
{
    if (number == 1 || number == 0) return 1;
    return number * FactorialMethod(number - 1);
    
}

Console.WriteLine(FactorialMethod(Convert.ToInt32(Console.ReadLine())));
