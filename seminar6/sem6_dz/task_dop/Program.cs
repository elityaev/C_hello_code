// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

void GetNumCnt(int number, int count = 0)
{
    
    if (number == 0) 
    {
        Console.WriteLine(count);
    }
    else GetNumCnt(number/10, count+1); 
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetNumCnt(number);


