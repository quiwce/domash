using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите число от 1 до 7, обозначающее день недели (или 'exit' для выхода):");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;

                int x = int.Parse(input);

                string result = day(x);

                Console.WriteLine($"Результат: {result}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите допустимое целое число.\n");
            }
        }
    }

    public static string day(int x)
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }
}