// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] createArray()
{
    Console.Write("Введите размер массива: ");
    string lengthStr = Console.ReadLine()!;
    {
        for (int i = 1; i > 0; i++)
        {
            if (!int.TryParse(lengthStr, out int result))
            {
                Console.Write("Ошибка. Введите числовое значение: ");
                lengthStr = Console.ReadLine()!;
            }
            else if (result < 0)
            {
                Console.Write("Ошибка.Вы ввели отрицатильное значение. Введите числовое положительное значение: ");
                lengthStr = Console.ReadLine()!;
            }
            else break;
        }
        int[] arr = new int[int.Parse(lengthStr)];
        var random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(100, 1000);
        }
        return arr;
    }
}
void printArray(int[] array)
{
    string result = "Сгенерируемый массив: [";
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            result += array[i] + ", ";
        }
        else if (i == array.Length - 1)
        {
            result += array[i];

        }
    }
    result += "]";
    Console.WriteLine(result);
}
bool evenOrNotEven(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int searchEvenInArray(int[] array)
{
    int numOfEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (evenOrNotEven(array[i]))
        {
            numOfEvenNum += 1;
        }
    }
    return numOfEvenNum;
}
int[] array = createArray();
printArray(array);
Console.WriteLine("Количество четных элементов = " + searchEvenInArray(array));
