using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                bool result = is2Digits(number);
                Console.WriteLine($"Число {number} двузначное: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            }
        }

        Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
        Console.ReadLine();
    }

    public static bool is2Digits(int x)
    {
        return x >= 10 && x <= 99 || x <= -10 && x >= -99;
    }
}