// Составить частотный словарь элементов двумерного массива. 
// астотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3  
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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


// Первый вариант
// for (int k = 0; k < 10; k++)
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] == k)
//             {
//                 count++;
//             }
//         }
        
//     }
//     if (count != 0)
//     Console.WriteLine($"Кол-во повторений для {k} = {count}");   
// }


// Второй вариант 

int[] countArray = new int[10];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        countArray[matrix[i,j]]++;
    }
}

for (int i = 0; i < countArray.Length; i++)
{
    if (countArray[i] > 0)
    {
        Console.WriteLine($"Кол-во повторений для {i} = {countArray[i]}");
    }
}