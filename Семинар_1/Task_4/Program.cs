﻿Console.WriteLine ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberС > max) max = numberС;

Console.Write ("Максимальное число: ");
Console.WriteLine (max);