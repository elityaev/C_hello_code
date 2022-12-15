// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Первый вариант
// int sum = 0;
// void GetSum (int num) 
// {   
//     if(num == 0)
//     {
//         Console.WriteLine(sum);
//         return;
//     }
//     sum += num%10;
//     GetSum(num /= 10);
// }

// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());
// GetSum(m);


// Second var

int GetSum(int num)
{
    if (num == 0)
    {
        return 0; 
    }
    return num % 10 + GetSum(num / 10);
}

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(GetSum(m));
