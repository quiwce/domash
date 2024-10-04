using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число (a):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число (b):");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число (c):");
            int c = int.Parse(Console.ReadLine());

            bool result = isEqual(a, b, c);
            Console.WriteLine($"Все три числа равны: {result}");
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

    public static bool isEqual(int a, int b, int c)
    {
        // Проверяем равенство всех трех чисел.
        return a == b && b == c;
    }
}
