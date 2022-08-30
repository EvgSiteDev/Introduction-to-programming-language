// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] orderingAnArrayByRows(int[,] array)
{
    int[,] orderedArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] rowGeneratedArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowGeneratedArray[j] = array[i, j];
        }
        Array.Sort(rowGeneratedArray);
        Array.Reverse(rowGeneratedArray);
        for (int k = 0; k < rowGeneratedArray.Length; k++)
        {
            orderedArray[i, k] = rowGeneratedArray[k];
        }
    }
    return orderedArray;
};

int[,] generatedArray = createArray();
printArray(generatedArray, "Сгенерированный массив: ");
int[,] orderedArray = orderingAnArrayByRows(generatedArray);
printArray(orderedArray, "Упорядоченный массив: ");

