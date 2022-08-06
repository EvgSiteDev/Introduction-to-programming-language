string  numString,
        allEvenNumString = "";

int num;

Console.WriteLine("Все четные числа от 1 до введенного");
Console.Write("Введите целое число:");
numString = Console.ReadLine()!;
num = int.Parse(numString);

for (int counter = 2; counter <= num; counter += 2)
{
    allEvenNumString += counter;

    if (counter + 2 > num) {
        allEvenNumString += ".";        
    }
    else {
        allEvenNumString += ","; 
    }
}


Console.WriteLine("Четные числа от 1 до " + num + ": " + allEvenNumString);