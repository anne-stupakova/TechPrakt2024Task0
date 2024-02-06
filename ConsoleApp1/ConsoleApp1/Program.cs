using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введіть перше число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введіть друге число:");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"Сума чисел {number1} та {number2} дорівнює: {sum}");
        }
        else
        {
            Console.WriteLine("Некоректний ввід. Будь ласка, введіть числа.");
        }

        Console.ReadLine();
    }
}
