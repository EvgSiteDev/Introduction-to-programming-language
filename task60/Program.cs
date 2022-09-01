string[,,] creatingAThreeDimensionalArray(int numRowArray, int numColumnArray, int numDepthArray)
{
    string[,,] array = new string[numRowArray, numColumnArray, numDepthArray];
    var random = new Random(); ;
    int beginNumber = random.Next(10, 20);
    for (int i = 0; i < numDepthArray; i++)
    {
        for (int j = 0; j < numRowArray; j++)
        {
            for (int k = 0; k < numColumnArray; k++)
            {
                array[j, k, i] = beginNumber + " (" + j + "," + k + "," + i + ")";
                beginNumber += random.Next(1, 10);
            }
        }
    }
    return array;
}
void printAThreeDimensionalArray(string[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(array[j, k, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
printAThreeDimensionalArray(creatingAThreeDimensionalArray(2, 2, 2));

