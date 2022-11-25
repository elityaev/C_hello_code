// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("Диапозон возможных координат: x > 0, y > 0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("Диапозон возможных координат: x < 0, y > 0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("Диапозон возможных координат: x < 0, y < 0");
// }
// else
// {
//     Console.WriteLine("Диапозон возможных координат: x > 0, y < 0");
// }

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};
if (num >= 1 && num <= 4)
{
    Console.WriteLine($"Диапозон возможных координат: {array[num - 1]}");
}
else
{
    Console.WriteLine("Такой четверти нет");
}
