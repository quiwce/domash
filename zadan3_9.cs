using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите положительное целое число для высоты треугольника (или 'exit' для завершения):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int x) && x > 0)
            {
                rightTriangle(x);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное положительное число.");
            }
        }
    }

    public static void rightTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            // Выводим пробелы
            for (int j = 0; j < x - i - 1; j++)
            {
                Console.Write(" ");
            }
            // Выводим звездочки
            for (int k = 0; k < i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}