using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите два целых числа (или 'exit' для выхода):");

                Console.Write("Введите число x: ");
                string inputX = Console.ReadLine();
                if (inputX.ToLower() == "exit") break;

                Console.Write("Введите число y: ");
                string inputY = Console.ReadLine();
                if (inputY.ToLower() == "exit") break;

                int x = int.Parse(inputX);
                int y = int.Parse(inputY);

                int result = sum2(x, y);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректные целые числа.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
    }

    public static int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        return sum;
    }
}