int[,,] fillingTheArraySpirally()
{
    int[,,] array = new int[4, 4, 4];
    int num = 1;
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, j, i] = num;
            num += 1;
        }
        for (int k = 1; k < array.GetLength(0); k++)
        {
            array[k, array.GetLength(1) - 1, i] = num;
            num += 1;
        }
        for (int z = array.GetLength(1) - 2; z >= 1; z--)
        {
            array[array.GetLength(0) - 1, z, i] = num;
            num += 1;
        }
        for (int f = array.GetLength(0) - 1; f > 0; f--)
        {
            array[f, 0, i] = num;
            num += 1;
        }
        for (int p = 1; p < array.GetLength(1) - 1; p++)
        {
            array[1, p, i] = num;
            num += 1;
        }
        for (int b = 2; b < array.GetLength(0) - 1; b++)
        {
            array[b, 2, i] = num;
            num += 1;
        }
        for (int l = array.GetLength(1) - 3; l > 0; l--)
        {
            array[2, l, i] = num;
            num += 1;
        }

    }
    return array;
}
void printAThreeDimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        Console.WriteLine(i + 1 + " часть");
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[j, k, i] < 10)
                {
                    Console.Write("0" + array[j, k, i] + " ");
                }
                else
                {
                    Console.Write(array[j, k, i] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();


    }
}
printAThreeDimensionalArray(fillingTheArraySpirally());