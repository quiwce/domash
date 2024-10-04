using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ от '0' до '9':");

        while (true)
        {
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Перенос на новую строку

            if (char.IsDigit(input))
            {
                int result = charToNum(input);
                Console.WriteLine($"Числовое значение: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректный символ от '0' до '9'.");
            }
        }

        Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
        Console.ReadLine();
    }

    public static int charToNum(char x)
    {
        return x - '0';
    }
}
