﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива m x n: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите введите № строки: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № колонки: ");
int column = Convert.ToInt32(Console.ReadLine());

if (line - 1 <= m && column - 1 <= n)
{
    Console.WriteLine($"В строке {line} колонке {column} находится элемент со значение {matrix[line-1,column-1]}");
}
else
{
    Console.WriteLine("Введенные параметры выходят за рамки массива");
}
