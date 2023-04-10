using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите число:");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0) {
            Console.WriteLine("Да, число чётное.");
        } else {
            Console.WriteLine("Нет, число нечётное.");
        }
    }
}
