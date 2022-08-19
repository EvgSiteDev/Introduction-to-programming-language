double[] createArray()
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
        double[] arr = new double[int.Parse(lengthStr)];
        var random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
        }
        return arr;
    }
}
void printArray(double[] array)
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
double diffBetweenMinAndMaxArr(double[] array)
{
    double diff = array.Max() - array.Min();
    return diff;
}

double[] array = createArray();
printArray(array);
Console.WriteLine("Разница между максимальным значением массива и минимальным составит: " + diffBetweenMinAndMaxArr(array));

