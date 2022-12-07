// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.WriteLine("Введите размерность двумерного массива m x n: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
int sum = 0; 
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
        if (i == j)
        {
            sum += matrix[i,j]; 
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов главной диагонали - {sum}");
