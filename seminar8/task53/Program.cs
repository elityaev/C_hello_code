// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность двумерного массива m x n: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m, n); 
PrintArray(matrix);

int temp = 0; 
for (int i = 0; i < n; i++)
{
    temp = matrix[0,i];
    matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
    matrix[matrix.GetLength(0)-1,i] = temp;
}
Console.WriteLine();

PrintArray(matrix);