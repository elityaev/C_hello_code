// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
string input = Console.ReadLine();
int inputLen = input.Length;
if (inputLen == 5)
{
    for (int i = 0; i < inputLen / 2; i ++)

    if (input[i] != input[inputLen - i -1])
    {
        Console.WriteLine("Нет");
        break;
    }
    else
    {   
        if (i == input.Length / 2 - 1)
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Ввод не соответсвует условиям");
}

// Не смог придумать другого варианта, чтобы несколько раз не выводилось "Да" 



