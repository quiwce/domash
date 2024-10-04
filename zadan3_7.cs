using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите положительное целое число для размера квадрата (или 'exit' для завершения):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            if (int.TryParse(input, out int x) && x > 0)
            {
                square(x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            }
        }
    }

    public static void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}