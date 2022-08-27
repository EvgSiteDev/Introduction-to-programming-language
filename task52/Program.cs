// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] createArray()
{
    var random = new Random();
    int numberOfRows = random.Next(3, 9);
    int numberOfColumns = random.Next(3, 9);
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
void printArray(int[,] array)

{
    Console.WriteLine("Сгенерированный массив:");
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
int[,] array = createArray();
printArray(array);

string findingTheArithmeticMeanOfColumns(int[,] array)
{
    int summArrayElement = 0;
    string arithmeticMeanList = "Средние арифметические каждого столбца: ";
    double arithmeticMean = 0;
    double rowLength = array.GetLength(0);
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summArrayElement += array[j, i];
        }

        arithmeticMean = summArrayElement / rowLength;
        summArrayElement = 0;
        arithmeticMeanList += Math.Round(arithmeticMean, 2) + "; ";
    }
    return arithmeticMeanList;
}
Console.WriteLine(findingTheArithmeticMeanOfColumns(array));
