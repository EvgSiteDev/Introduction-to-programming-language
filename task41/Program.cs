// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int numberOfNumbersGreaterThanZero()
{
    Console.Write("Сколько чисел вы будете вводить?: ");
    string numOfNumStr = Console.ReadLine()!;
    int numOfNum = 0;
    for (; ; )
    {
        if (!int.TryParse(numOfNumStr, out int result))
        {
            Console.Write("Ошибка. Введите числовое значение: ");
            numOfNumStr = Console.ReadLine()!;
        }
        else if (result < 0)
        {
            Console.Write("Ошибка.Вы ввели отрицатильное значение. Введите числовое положительное значение: ");
            numOfNumStr = Console.ReadLine()!;
        }
        else
        {
            numOfNum = result;
            break;
        }

    }
    string numberStr = string.Empty;
    int number = 0,
    greaterThenZero = 0;
    for (int i = 1; i <= numOfNum; i++)
    {
        Console.Write("Введите " + i + " число: ");
        numberStr = Console.ReadLine()!;
        for (; ; )
        {
            if (!int.TryParse(numberStr, out int result))
            {
                Console.Write("Ошибка. Введите числовое значение: ");
                numberStr = Console.ReadLine()!;
            }
            else
            {
                number = result;
                break;

            }
        }
        if (number > 0)
        {
            greaterThenZero += 1;
        }
        else continue;
    }
    return greaterThenZero;
}

Console.WriteLine("Чисел больше нуля: " + numberOfNumbersGreaterThanZero());

