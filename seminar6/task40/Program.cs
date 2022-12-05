// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
// двух других сторон

Console.WriteLine("Введите длину стороны А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину стороны B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину стороны C: ");
double C = Convert.ToDouble(Console.ReadLine());

if (A < B + C & B < A + C & C < A + B) 
{
    Console.WriteLine($"Треугольник со сторонами длиной {A} {B} {C} может сущестовать");
    
}
else 
{
    Console.WriteLine($"Треугольник со сторонами длиной {A} {B} {C} НЕ может сущестовать");
}