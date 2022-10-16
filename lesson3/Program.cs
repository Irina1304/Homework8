/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



int EnterInt(string hint)
{
    Console.Write(hint);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyArray(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int heightMatrix1 = EnterInt("Введите количество строк в первой матрице: ");
int widthMatrix1 = EnterInt("Введите количество столбцов в первой матрице: ");
int[,] matrix1 = new int[heightMatrix1, widthMatrix1];
Console.WriteLine("Первая матрица:");
Fill2DArray(matrix1);
Print2DArray(matrix1);

int heightMatrix2 = EnterInt("Введите количество строк во второй матрице: ");
int widthMatrix2 = EnterInt("Введите количество столбцов во второй матрице: ");
int[,] matrix2 = new int[heightMatrix2, widthMatrix2];
Console.WriteLine("Вторая матрица:");
Fill2DArray(matrix2);
Print2DArray(matrix2);

Console.WriteLine("Произведение двух матриц:");
Print2DArray(MultiplyArray(matrix1, matrix2));



