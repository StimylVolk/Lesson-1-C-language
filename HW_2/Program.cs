﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое числое большее, а какое меньшее

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("a = ");
int number_a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int number_b = int.Parse(Console.ReadLine());

int max = 0;

if (number_a > number_b) max = number_a;
else max = number_b;

Console.WriteLine($"Max number = {max}");
