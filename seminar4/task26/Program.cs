// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// void NumberCount()
// {
//     Console.Write("Введите число: ");
//     string number = Console.ReadLine();
//     Console.Write($"В числе '{number}' {number.Length} цифр(ы)");
// }

// NumberCount();

//------------------------------------------------------------------------------------

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string strnum = num.ToString();
// Console.Write($"В числе '{num}' {strnum.Length} цифр(ы)");

//---------------------------------------------------------------------------------------

string? A = Console.ReadLine();
if (int.TryParse(A, out int num))
    Console.WriteLine("Количество цифр в числе:" + A.Length);
else 
    Console.WriteLine("Не правильный ввод, напишите число!");

