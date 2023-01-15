/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
 максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите значение 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение 3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if (Number2 > Number1)
{
    max = Number2;
}
if (Number3 > Number2)
{
    max = Number3;
}
Console.WriteLine($"max =  {max}");
