/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetОrderedArray(int[,] innumbers)
{
    for (int i = 0; i < innumbers.GetLength(0); i++)
    {
        for (int j = 0; j < innumbers.GetLength(1); j++)
        {
            for (int n = 0; n < innumbers.GetLength(1) - 1; n++)
            { 
                if (innumbers[i, n] < innumbers[i, n + 1])
                {
                    int temp = innumbers[i, n];
                    innumbers[i, n] = innumbers[i, n + 1];
                    innumbers[i, n + 1] = temp;
                }
            }
        }
    }
}



int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
GetОrderedArray(matrix);
Console.WriteLine();
PrintMatrix(matrix);

