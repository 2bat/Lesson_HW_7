// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

string number(int N, int M)
{
    if (N>=M) return number(N -1, M) + $"{N} ";
    else return " ";
}
 
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"Натуральные числа в заданном промежутке: {number(N,M)}");
