using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите целое число для проверки, делится ли оно на 3 или 5, или 'exit' для выхода:");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                int x = int.Parse(input);
                bool result = is35(x);

                Console.WriteLine($"Результат для числа {x}: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: пожалуйста, введите корректное целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }
        }
    }

    public static bool is35(int x)
    {
        bool divisibleBy3 = x % 3 == 0;
        bool divisibleBy5 = x % 5 == 0;

        if (divisibleBy3 && divisibleBy5)
        {
            return false;
        }

        return divisibleBy3 || divisibleBy5;
    }
}