using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите целое число для получения его модуля, или 'exit' для выхода:");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                int x = int.Parse(input);
                Console.WriteLine($"Модуль числа {x} равен: {Abs(x)}");
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

    public static int Abs(int x)
    {
        return x < 0 ? -x : x;
    }
}
