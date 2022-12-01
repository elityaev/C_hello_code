// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

Console.WriteLine("Задайте размер массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) sum += array[i];
}
Console.Write(sum);


