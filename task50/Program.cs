// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] createArray()
{
    var random = new Random();
    int numberOfRows = random.Next(3, 10);
    int numberOfColumns = random.Next(3, 10);
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
int [,] array = createArray();
printArray(array);

void searchByIndex(int[,] array)
{
    
    Console.Write("Введите индекс строки: ");
    int numRow = int.Parse(Console.ReadLine()!);
    Console.Write("Введите индекс столбца: ");
    int numColumn = int.Parse(Console.ReadLine()!);
    if (numRow >= array.GetLength(0) || numColumn >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
    {
        Console.WriteLine("Элемент массива равен: " + array[numRow,numColumn]);
    }
}
searchByIndex(array);