using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Максимальное число: " + a);
            Console.WriteLine("Минимальное число: " + b);
        }
        else if (b > a)
        {
            Console.WriteLine("Максимальное число: " + b);
            Console.WriteLine("Минимальное число: " + a);
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }
}
