﻿// // Напишите программу, которая выводит случайное число из 
// // отрезка [10, 99] и показывает наибольшую цифру числа.

// // Например:
// // 78 -> 8
// // 12-> 2
// // 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int num1= num / 10;
// int num2= num % 10;

// if(num1>num2)
// {
//     Console.WriteLine("Число "+ num1+ " больше чем...");  //канкатинация
// }
// else
// {
//     Console.WriteLine($"Число {num2}  больше чем...");  //интерполяция
// }

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,10000);
// Console.WriteLine(num);

// int num1= num / 100;
// int num2= num % 10;
// int result = num1 * 10 + num2;

// Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход
//  два числа и выводить, является ли второе число кратным 
//  первому. Если число 2 не кратно числу 1, то программа 
//  выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num % num1==0)
// {
//     Console.WriteLine("Кратные");
// }
// else
// {
//     Console.WriteLine("Остаток равен " + num % num1);
// }

// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

//    && - все условия выпол.
//    || - хотя одно из

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if((num1 % 7==0) && (num1 % 23==0))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Напишите программу, которая принимает на вход два числа и
//  проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if((num1== num2*num2)|| (num2==num1*num1))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача №17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
//  плоскости, в которой находится эта точка.

// Задача №17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
//  плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if(X>0 && Y>0)
// {
//     Console.WriteLine("1");
// }
// else if(X<0 && Y>0)
// {
//     Console.WriteLine("2");
// }
// else if(X<0 && Y<0)
// {
//     Console.WriteLine("3");
// }
// else if(X>0 && Y<0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси");
// }