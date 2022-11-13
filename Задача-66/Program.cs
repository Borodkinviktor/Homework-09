﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m = InputInt("Введите M ");
int n = InputInt("Введите N ");
Console.WriteLine($"Сумма элементов равна -> {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
