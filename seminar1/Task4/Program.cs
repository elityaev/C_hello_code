Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= numberA){
    if (i % 2 == 0){
        Console.Write($"{i}, ");
    } 
    i++;
}