// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int [] FillArray(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));
Console.Write("Введите размер число, которое нужно найти: ");
int number = Convert.ToInt32(Console.ReadLine());


// Вариант 1
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         Console.Write("Да");
//         break;
//     }
//     else 
//     {
//         if (i == array.Length - 1)
//         {
//             Console.Write("Нет");
//         }

//     }
// }


// Вариант 2

bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        flag = true;
        break;
    }
}
if (flag) Console.Write("Да");
else Console.Write("Нет");