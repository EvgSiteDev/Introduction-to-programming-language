int[] createArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    return arr;
}
void printArray(int[] array)
{
    string result = "[";
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

printArray(createArray(8));