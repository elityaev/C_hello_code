// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находтся в первой четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находтся в второй четверти");
}
else if (x < 0 && y < 0 )
{
    Console.WriteLine("Точка находтся в третьей четверти");
}
else 
{
    Console.WriteLine("Точка находтся в четвертой четверти");
}

