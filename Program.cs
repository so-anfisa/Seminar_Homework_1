// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
 int number1 = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите второе число: ");
 int number2 = int.Parse(Console.ReadLine()!);
 int max = number1;

if (max >= number2)
{
    max = number1;
}
else 
{
    max = number2 ;
}
Console.WriteLine($"Между чисел {number1} и {number2} большим является число {max}");