// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] arr = new double [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
    return arr;
}

Console.WriteLine("Задайте размер массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= max) max = array[i];
    else min = array[i];
}

Console.WriteLine(Math.Round((max - min), 4));