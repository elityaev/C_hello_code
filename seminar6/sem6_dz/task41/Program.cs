// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine($"Введите {size} чисел для заполнения массива");
int count = 0; 
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count ++; 
}
Console.WriteLine(count);

