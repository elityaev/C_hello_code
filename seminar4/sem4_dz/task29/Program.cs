// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int [] arr = new int [8];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Ввидите {i+1}-e число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


Console.Write('[' + string.Join(", ", arr) + ']');