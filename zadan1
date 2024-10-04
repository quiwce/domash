using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вещественное число для получения его дробной части:");

        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное вещественное число.");
            }
        }

        double fractionalPart = Fraction(number);
        Console.WriteLine($"Дробная часть числа {number} равна: {fractionalPart}");

        // Добавлено для предотвращения мгновенного закрытия консоли
        Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
        Console.ReadLine();
    }

    public static double Fraction(double x)
    {
        return x - Math.Truncate(x);
    }
}
