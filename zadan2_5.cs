using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введите три целых числа для нахождения максимального значения (или 'exit' для выхода):");

                Console.Write("Введите число x: ");
                string inputX = Console.ReadLine();
                if (inputX.ToLower() == "exit") break;

                Console.Write("Введите число y: ");
                string inputY = Console.ReadLine();
                if (inputY.ToLower() == "exit") break;

                Console.Write("Введите число z: ");
                string inputZ = Console.ReadLine();
                if (inputZ.ToLower() == "exit") break;

                int x = int.Parse(inputX);
                int y = int.Parse(inputY);
                int z = int.Parse(inputZ);

                int maximum = max3(x, y, z);

                Console.WriteLine($"Максимальное значение из ({x}, {y}, {z}): {maximum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: пожалуйста, введите корректные целые числа.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }
        }
    }

    public static int max3(int x, int y, int z)
    {
        int maxXY = (x > y) ? x : y;
        return (maxXY > z) ? maxXY : z;
    }
}