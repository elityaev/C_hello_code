// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а 
// первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] FillArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

Console.Write("Введите размен массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

ReverseArray(array);
Console.WriteLine(string.Join(", ", array));

