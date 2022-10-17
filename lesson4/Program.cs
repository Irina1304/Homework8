/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void Fill3DArray(int[,,] array, int[] fill)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = fill[n++];
            }
        }
    }
}

void Print3DArray(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int d = 0; d < inputMatrix.GetLength(2); d++)
            {
                Console.Write($"{inputMatrix[i, j, d]}({i},{j},{d})   ");
            }
            Console.WriteLine();
        }
    }
}

int[] FillUniqArray(int[,,] array)
{
    int[] matrix = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    if (matrix.Length > 90)
    {
        throw new Exception("Неповторяющиеся двухзначные числа закончились, введите меньшие значения m, n или k.");
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random r = new Random();
        int y = 0;
        matrix[i] = r.Next(10, 100);
        y = matrix[i];

        for (int j = 0; j < i; j++)
        {
            while (matrix[i] == matrix[j])
            {
                matrix[i] = r.Next(10, 100);
                j = 0;
                y = matrix[i];
            }
            y = matrix[i];
        }
    }
    return matrix;
}


int m = GetNumber("Введите значение m: ");
int n = GetNumber("Введите значение n: ");
int k = GetNumber("Введите значение k: ");

int[,,] matrix = new int[m, n, k];
int[] fill = FillUniqArray(matrix);
Fill3DArray(matrix, fill);
Print3DArray(matrix);
