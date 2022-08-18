// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

string dataVerification(string numStr)
{
    for (int i = 1; i > 0 ; i++ )
    {
        if (int.TryParse(numStr, out int result) == false)
        {
            Console.Write("Ошибка. Введите числовое значение: ");
            numStr = Console.ReadLine()!;
        }
        else if (int.Parse(numStr) < 0)
        {
            Console.Write("Ошибка.Вы ввели отрицатильное значение. Введите числовое положительное значение: ");
            numStr = Console.ReadLine()!;
        }
        else break;
    }
        return numStr;
}
int dataEntry(string text)
{
    Console.Write(text + ": ");
    string numString = Console.ReadLine()!;
    numString = dataVerification(numString);
    int num = int.Parse(numString);
    return num;
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
