// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
            arr[i] = random.Next(-99, 100);
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

int summNumInOddPositions(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        summ += array[i];
    }
    return summ;
}
int[] array = createArray();
printArray(array);
Console.WriteLine("Сумма чисел на нечетных позициях массива = "+ summNumInOddPositions(array));