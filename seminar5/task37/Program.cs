// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}


Console.Write("Введите размен массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.Write(string.Join(", ", array));

Console.WriteLine();

// Вариант 1
// if (array.Length % 2 == 0)
// {
//     int[] array2 = new int[array.Length / 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         array2[i] = array[i] * array[array.Length - i - 1]; 
//     }
//     Console.WriteLine(string.Join(", ", array2));
// }
// else
// {
//     int[] array2 = new int [array.Length / 2 + 1];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         array2[i] = array[i] * array[array.Length - 1 - i]; 
//     }
//     array2[array2.Length -1] = array[array.Length / 2];
//     Console.WriteLine(string.Join(", ", array2));
// }


// Вариант 2

int newLength = array.Length % 2 + array.Length / 2;
int[] newArray = new int[newLength];
for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 > 0)
{
    newArray[newArray.Length -1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", newArray));