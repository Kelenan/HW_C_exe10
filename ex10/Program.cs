/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num <= 99 || num >= 1000)
{
    Console.WriteLine("Читай внимательнее, человек!");
    return; 
}

int a1 = num / 10;
int a2 = a1 % 10;
Console.WriteLine($"num = {num}, resalt = {a2}");


