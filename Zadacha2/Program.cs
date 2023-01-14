/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
 какое число большее, а какое меньшее.ss

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите значение 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if (Number2 < max)
{
    Console.WriteLine($"max =  {max}");
    Console.Write($"min =  {Number2}");
}
else
{
    Console.WriteLine($"max =  {Number2}");
    Console.Write($"min =  {max}");
}