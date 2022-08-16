// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int dataEntry(string text)
{
    Console.Write(text + ": ");
    return int.Parse(Console.ReadLine()!);
};

int num = dataEntry("Введите число");
int degree = dataEntry("Введите степень");

int exponentiation(int number, int degr)
{
    int res = 1;
    for (int i = 1; i <= degr; i++)
    {
        res *= number;
    }
    return res;
}

void outputData(int number, int degreeOfNumber)
{
    Console.WriteLine(number + "^" + degreeOfNumber + " = " + exponentiation(num, degree));
}
outputData(num, degree);
