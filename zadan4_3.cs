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
                Console.WriteLine("Некорректный ввод. Убедитесь, что ввели только целые числа.");
                continue;
            }

            int maxAbsValue = MaxAbs(arr);
            Console.WriteLine($"Наибольшее по модулю значение в массиве: {maxAbsValue}");
        }
    }

    public static int MaxAbs(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.");
        }

        int maxAbsValue = arr[0];

        foreach (var num in arr)
        {
            if (Math.Abs(num) > Math.Abs(maxAbsValue))
            {
                maxAbsValue = num;
            }
        }

        return maxAbsValue;
    }
}