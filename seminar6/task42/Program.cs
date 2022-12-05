// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Вариант с рекурсией
void BinaryView(int number)
{
    if(number == 0)
    {
        return;
    }
    BinaryView(number/2);
    Console.Write(number%2);

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
BinaryView(number);

// Вариант без рекурсии

// while (number != 0) 
// {
//     Console.WriteLine(number % 2);
//     number /= 2;
// }




