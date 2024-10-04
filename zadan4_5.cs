using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы основного массива, разделенные пробелом:");
        int[] arr = ReadArrayFromConsole();

        Console.WriteLine("Введите элементы массива для вставки, разделенные пробелом:");
        int[] ins = ReadArrayFromConsole();

        Console.WriteLine("Введите позицию, куда будет вставлен второй массив:");
        int pos = ReadPositionFromConsole(arr.Length);

        int[] result = Add(arr, ins, pos);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(" ", result));

        // Ожидание ввода, чтобы консоль не закрылась сразу
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static int[] ReadArrayFromConsole()
    {
        string input = Console.ReadLine();
        return Array.ConvertAll(input.Split(' '), int.Parse);
    }

    static int ReadPositionFromConsole(int length)
    {
        int pos;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out pos) && pos >= 0 && pos <= length)
            {
                break;
            }
            Console.WriteLine("Введите корректную позицию (от 0 до " + length + "):");
        }
        return pos;
    }

    static int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        Array.Copy(arr, result, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        return result;
    }
}