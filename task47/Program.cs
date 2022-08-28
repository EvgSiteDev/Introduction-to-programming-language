// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
int dataVerification(string numOfNumStr)
{
    for (; ; )
    {
        if (!int.TryParse(numOfNumStr, out int result))
        {
            Console.Write("Ошибка. Введите числовое значение: ");
            numOfNumStr = Console.ReadLine()!;
        }
        else if (result < 0)
        {
            Console.Write("Ошибка.Вы ввели отрицатильное значение. Введите числовое положительное значение: ");
            numOfNumStr = Console.ReadLine()!;
        }
        else
        {
            return result;
        }

    }
}

double[,] createArray()
{
    Console.Write("Введите количество строк: ");
    int numberOfRows = dataVerification(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int numberOfColumns = dataVerification(Console.ReadLine()!); ;
    var random = new Random();
    double[,] array = new double[numberOfRows, numberOfColumns];
    for (int i = 0; i < numberOfRows; i++)
    {
        for (int j = 0; j < numberOfColumns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10, 1);
        }
    }
    return array;
};
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
printArray(createArray());