// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] createMatrix(int numRow,int numCol)
{
    var random = new Random();
    int[,] array = new int[numRow, numCol];
    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < numCol; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
};
void printMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    Console.WriteLine("Умножение матриц: ");
    string returnArrayRowString(int[,] matrix, int numString, string rowString)
    {

        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            if (j + 1 < firstMatrix.GetLength(1))
            {
                rowString += matrix[numString, j] + ",";
            }
            else
            {
                rowString += matrix[numString, j];
            }
        }
        return rowString;
    }
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        string rowArrayString = string.Empty;
        rowArrayString = returnArrayRowString(firstMatrix, i, rowArrayString);
        rowArrayString += " | ";
        rowArrayString = returnArrayRowString(secondMatrix, i, rowArrayString);
        Console.WriteLine(rowArrayString);
    }
}
int[,] calculationOfMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] calculationResult = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    int[] returningASingleRowOfAtwoDimensionalArray(int[,] array, int indexRow)
    {
        int[] rowArrow = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            rowArrow[i] = array[indexRow, i];
        }
        return rowArrow;
    }
    int[] returningASingleColumnOfAtwoDimensionalArray(int[,] array, int indexColumn)
    {
        int[] columnArrow = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnArrow[i] = array[i, indexColumn];
        }
        return columnArrow;
    }
    for (int k = 0; k < firstMatrix.GetLength(1); k++)
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            int[] rowArray = returningASingleRowOfAtwoDimensionalArray(firstMatrix, k);
            int[] columnArray = returningASingleColumnOfAtwoDimensionalArray(secondMatrix, i);

            for (int j = 0; j < rowArray.Length; j++)
            {
                calculationResult[k, i] += rowArray[j] * columnArray[j];
            }
        }
    }


    return calculationResult;
};

void printCalculatedResultArray(int[,] array, string viewText)

{
    Console.WriteLine(viewText);
    Console.WriteLine("_______________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1)
            {
                Console.Write(array[i, j] + ",");

            }
            else
            {
                Console.Write(array[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("_______________________");
}


int[,] firstMatrix = createMatrix(3,3);
int[,] secondMatrix = createMatrix(3,3);
printMatrices(firstMatrix, secondMatrix);
int[,] calculatedResult = calculationOfMatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine();
printCalculatedResultArray(calculatedResult, "Результат умножения матриц: ");








