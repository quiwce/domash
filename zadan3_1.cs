using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите положительное целое число (или 'exit' для выхода):");

            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            try
            {
                int x = int.Parse(input);
                if (x < 0)
                {
                    Console.WriteLine("Пожалуйста, введите неотрицательное число.");
                    continue;
                }

                string result = listNums(x);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число. Попробуйте ещё раз.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком большое. Попробуйте ещё раз.");
            }
        }
    }

    public static string listNums(int x)
    {
        string[] numbers = new string[x + 1];

        for (int i = 0; i <= x; i++)
        {
            numbers[i] = i.ToString();
        }

        return string.Join(" ", numbers);
    }
}