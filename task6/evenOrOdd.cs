string  numString;

int num;

Console.WriteLine("Четное или нечетное число");
Console.Write("Введите целое число:");
numString = Console.ReadLine()!;
num = int.Parse(numString);
int remains = num % 2;

if (remains == 1)
{
    Console.WriteLine("Ваше число нечетное");
}
else if (remains == 0)
{
    Console.WriteLine("Ваше число четное");
}