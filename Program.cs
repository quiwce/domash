using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите левую границу диапазона (a):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите правую границу диапазона (b):");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число для проверки (num):");
            int num = int.Parse(Console.ReadLine());

            bool result = isInRange(a, b, num);
            Console.WriteLine($"Число {num} входит в диапазон [{Math.Min(a, b)}, {Math.Max(a, b)}]: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректное числовое значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        // Добавляем паузу, чтобы консоль не закрывалась.
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static bool isInRange(int a, int b, int num)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return num >= min && num <= max;
    }
}