﻿//Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на само себя).
//Например: 4->16
//-3->9 -7->49

/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
20 мин
 
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 5 -> Пятница
*/

int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);