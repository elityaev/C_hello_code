// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Math.Sqrt(); // корень
// Math.Pow(a, 2); // возведение в степень

Console.WriteLine("Введите координату точки x отрезка А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y отрезка А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки x отрезка B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y отрезка B: ");
int By = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)), 3);
Console.WriteLine($"Расстояние между точками A и B: {distance}");



