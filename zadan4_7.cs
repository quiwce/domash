using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелом:");

        int[] arr = ReadArrayFromConsole();

        int[] reversedArr = ReverseBack(arr);

        Console.WriteLine("Реверсированный массив:");
        Console.WriteLine(string.Join(" ", reversedArr));

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
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа, разделенные пробелом:");
            }
        }
    }

    public static int[] ReverseBack(int[] arr)
    {
        int[] reversedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - 1 - i];
        }
        return reversedArr;
    }
}