Console.Write("Введите целое число, до которого будет производится возведение в куб: ");

int maxCubeNum = int.Parse(Console.ReadLine()!);
string cubingFrom1ToN(int max)
{
    string cubeList = string.Empty;
    for (int i = 1; i <= max; i++)
    {
        if (i != max)
        {
            cubeList = cubeList + Math.Pow(i, 3) + ", ";
        }
        else if (i == max)
        {
            cubeList = cubeList + Math.Pow(i, 3) + ".";
        }
    }
    return cubeList;
}
Console.WriteLine(cubingFrom1ToN(maxCubeNum));