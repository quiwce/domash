using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите неотрицательное целое число (или 'exit' для завершения):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            try
            {
                int x = int.Parse(input);
                if (x < 0)
                {
                    throw new ArgumentException("Число должно быть неотрицательным.");
                }

                string result = chet(x);
                Console.WriteLine("Четные числа: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }

    public static string chet(int x)
    {
        return string.Join(" ", Enumerable.Range(0, x + 1).Where(n => n % 2 == 0));
    }
}