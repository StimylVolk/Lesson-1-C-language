﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число для проверки чётности: ");
int N = int.Parse(Console.ReadLine());

string s = "нет";
if (N % 2 == 0)
{
    s = "да";
}
Console.WriteLine(s);