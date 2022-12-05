// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void CopyArray(int[] array)
{
    int[] cpArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        cpArr[i] = array[i];
    }
    Console.WriteLine(string.Join(", ", cpArr));
}

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));
CopyArray(array);


