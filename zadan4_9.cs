using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелом:");

        int[] arr = ReadArrayFromConsole();

        Console.WriteLine("Введите число x:");
        int x = ReadIntegerFromConsole();

        int[] result = FindAll(arr, x);

        if (result.Length > 0)
        {
            Console.WriteLine("Индексы вхождений числа {0}:", x);
            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            Console.WriteLine("Число {0} не найдено в массиве.", x);
        }

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static int[] ReadArrayFromConsole()
    {
        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                return Array.ConvertAll(input.Split(' '), int.Parse);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректные целые числа, разделенные пробелами.");
            }
        }
    }

    static int ReadIntegerFromConsole()
    {
        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                return int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целое число.");
            }
        }
    }

    static int[] FindAll(int[] arr, int x)
    {
        List<int> indices = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                indices.Add(i);
            }
        }

        return indices.ToArray();
    }
}