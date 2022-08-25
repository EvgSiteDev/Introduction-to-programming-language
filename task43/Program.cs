// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double dataVerification(string meaningStr)
{
    for (; ; )
    {
        if (!double.TryParse(meaningStr, out double result))
        {
            Console.Write("Ошибка. Введите числовое значение: ");
            meaningStr = Console.ReadLine()!;
        }
        else
        {
            return result;

        }
    }
}
double dataEntering(string variableName)
{
    Console.Write("Введите " + variableName + " : ");
    string variableStr = Console.ReadLine()!;
    double result = dataVerification(variableStr);
    return result;
}

double b1 = dataEntering("b1");
double k1 = dataEntering("k1");
double b2 = dataEntering("b2");
double k2 = dataEntering("k2");

void findingTheIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Точек пересечения не существует. Линейные функции паралельны между собой.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double fX = k1 * x + b1;

        Console.WriteLine("Координаты точек пересечения: " + "(" + x + ";" + fX + ")");
    }
}
findingTheIntersectionPoint(b1, k1, b2, k2);