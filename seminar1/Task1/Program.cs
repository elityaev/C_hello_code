Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB){
    Console.WriteLine($"Число {numberA} большее, а число {numberB} меньшее");
}
else if (numberA < numberB) {
    Console.WriteLine($"Число {numberB} большее, а число {numberA} меньшее");
}
else{
   Console.WriteLine($"Числа {numberA} и {numberB} равны");
}
