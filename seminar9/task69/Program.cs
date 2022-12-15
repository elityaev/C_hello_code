// Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetDegree(int m, int n)
{
    if (n == 0)
    {
        return 1; 
    }
    return m * GetDegree(m, n - 1);
}

Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine(GetDegree(x, y));
