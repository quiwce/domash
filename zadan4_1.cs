using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите массив чисел, разделённых пробелом (или 'exit' для выхода):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            var strArr = input.Split(' ');
            int[] arr;

            try
            {
                arr = strArr.Select(int.Parse).ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода! Убедитесь, что вы ввели целые числа, разделённые пробелами.");
                continue;
            }

            Console.WriteLine("Введите число x для поиска:");
            string xInput = Console.ReadLine();
            int x;

            if (!int.TryParse(xInput, out x))
            {
                Console.WriteLine("Ошибка ввода! Пожалуйста, введите целое число.");
                continue;
            }

            int index = findFirst(arr, x);
            if (index != -1)
            {
                Console.WriteLine($"Первое вхождение числа {x} находится на индексе {index}.");
            }
            else
            {
                Console.WriteLine($"Число {x} не найдено в массиве.");
            }
        }
    }

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
}