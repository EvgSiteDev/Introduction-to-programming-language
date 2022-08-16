string aXStr = string.Empty,
aYStr = string.Empty,
aZStr = string.Empty,
bXStr = string.Empty,
bYStr = string.Empty,
bZStr = string.Empty;
double enteringCoordinates(string pointName, string axisName, string variableStr)
{
    Console.WriteLine("Введите координаты точки " + pointName + ": ");

    Console.Write(axisName + " = ");
    variableStr = Console.ReadLine()!;
    for (int i = 1; i >= 1; i++)
    {
        if (variableStr == "")
        {
            Console.Write("Вы не ввели координату. Введите " + axisName + " = ");
            variableStr = Console.ReadLine()!;

        }
        else
        {
            break;
        }
    }
    return double.Parse(variableStr);
}
double aXNum = enteringCoordinates("A", "x", aXStr),
aYNum = enteringCoordinates("A", "y", aYStr),
aZNum = enteringCoordinates("A", "z", aZStr),
bXNum = enteringCoordinates("B", "x", bXStr),
bYNum = enteringCoordinates("B", "y", bYStr),
bZNum = enteringCoordinates("B", "z", bZStr); ;

double result = Math.Sqrt(Math.Pow((bXNum - aXNum), 2) +
Math.Pow((bYNum - aYNum), 2) +
Math.Pow((bZNum - aZNum), 2));
Console.WriteLine("Расстояние будет равно: " + Math.Round(result, 2));




