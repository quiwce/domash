using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число (или 'exit' для завершения):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            try
            {
                long x = long.Parse(input);
                int length = numLen(x);
                Console.WriteLine($"Количество знаков в числе {x}: {length}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком большое или слишком маленькое.");
            }
        }
    }

    public static int numLen(long x)
    {
        if (x == 0) return 1;

        int length = 0;
        while (x != 0)
        {
            x /= 10;
            length++;
        }
        return length;
    }
}