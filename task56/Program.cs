// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] createArray()
{
    var random = new Random();
    int numberOfRows = random.Next(3, 9);
    int numberOfColumns = random.Next(2, 5);
    int[,] array = new int[numberOfRows, numberOfColumns];
    for (int i = 0; i < numberOfRows; i++)
    {
        for (int j = 0; j < numberOfColumns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
};
void printArray(int[,] array, string viewText)

{
    Console.WriteLine(viewText);
    Console.WriteLine("_______________________");
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("_______________________");
}

int calculatingTheRowNumberWithTheSmallestSumOfElements(int[,] array)
{
    int lineNumberWithTheSmallestSum = 0;
    double theSmallestSum = double.PositiveInfinity;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int calculatedSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            calculatedSum += array[i, j];
        }
        if (theSmallestSum > calculatedSum)
        {
            theSmallestSum = calculatedSum;
            lineNumberWithTheSmallestSum = i+1;
        }

    }
    return lineNumberWithTheSmallestSum;
}
int[,] array = createArray();
printArray(array, "Сгенерированный массив:");
Console.WriteLine("Строка с наименьшей суммой номер: "+calculatingTheRowNumberWithTheSmallestSumOfElements(array));