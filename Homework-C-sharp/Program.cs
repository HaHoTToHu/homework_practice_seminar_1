﻿/*Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число 
большее, а какое меньшее.
*/
// int a = -9;
// int b = -3;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// Console.WriteLine($"Максимальное число: {max}");

/* Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное 
 из этих чисел.*/
// int a = 22;
// int b = 3;
// int c = 9;
// int max = a;
// if(a > b & a > c) max = a;
// if (b > a & b > c) max = b;
// if (c > a & c > b) max = c;
// Console.WriteLine($"Наше максимальное число: {max}");

/*Задача 6: Напишите программу, которая на вход 
принимает число и выдаёт, является ли 
число чётным (делится ли оно на два без остатка).*/
// int a = 7;
// if (a % 2 == 0) Console.WriteLine($"Число {a} является чётным");
// else Console.WriteLine($"Число {a} является НЕчётным");

/*Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.*/
// Console.WriteLine("Введите Ваше число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= number)
// {
//     if(count %2 == 0)
//     Console.WriteLine(count);
//     count ++;
// }