﻿// Напишите программу, которая будет принимать на вход два числа и выводить, кратно ли первое число второму. Если первое число некратно второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// // 4, 3 => нет


Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;
if (result == 0)
{
Console.WriteLine("Первое число кратно второму числу");
}
else
{
Console.WriteLine($"Первое число не кратно второму числу\n Остаток от деления равен={result}");
//Console.WriteLine("Первое число не кратно второму числу\n Остаток от деления равен=" + result);
}