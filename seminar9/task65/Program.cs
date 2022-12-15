// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void GetNumbers (int start, int finish)
{
    if (finish < start) return;
    GetNumbers(start, finish-1);
    Console.Write($"{finish}, ");
}

Console.Write("Введите первое число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int finish = Convert.ToInt32(Console.ReadLine());
GetNumbers(start, finish);