﻿// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдает сумму чисел от 1 до А.
// 7->28
// 4->10
// 8->36

// тип переменной + Название + ()

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {
//     int sum = 0;
//     int count = 0;

//     while(count<=num)
//     {
//         //sum = sum + count;
//         sum+=count;
//         count++;
//     }
//     return sum;
// }
// int result = GetSumNum();
// Console.WriteLine(result);

// Console.WriteLine(GetSumNum());


// Задача 26: Напишите программу, которая принимает 
// на вход число и выдает количество цифр в числе.
// 456->3
// 78->2
// 89126->5

// int GetNum(int num)
// {
// int count;
// if(num > 0 && num < 10)
// {
// count = 1;
// }
// else if(num >= 10 && num < 100)
// {
// count = 2;
// }
// else if(num >= 100 && num < 1000)
// {
// count = 3;
// }
// else if(num >= 1000 && num < 10000)
// {
// count = 4;
// }
// else
// {
// count = 5;
// }

// return count;
// }
// Console.Write("Введите число: ");
// int num= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetNum(num));

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCountNum()
// {
//     int count = 0;

//     while(num>0)
//     {
//         num=num/10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine(GetCountNum());


// Задача 28:мНапишите программу, которая принимает 
// на вход число N и выдает произведение числе от 1 до N.
// 4->24
// 5->120

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetMultiNum()
// {
//     int multi=1;
    
//     for (int i=1; i<=num; i++)
//     {
//         multi = multi*i;
//     }
//     return multi;
// }
// Console.WriteLine(GetMultiNum());


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = new int[8];
// GetArray();

// void GetArray()
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i]=new Random().Next(0,2);
//         Console.Write(array[i]+" ");
//     }
// }




