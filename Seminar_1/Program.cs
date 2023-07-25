// Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умножения на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());

// int result= number*number;

// Console.WriteLine(result);


// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет
// a = 9, b = 3 -> да 
// a = -3, b = 9 -> нет

// Console.WriteLine("Введите число");
// int number1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2*number2)
// {
//     Console.WriteLine ("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Console.WriteLine("Введите чило");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого числа нет");
// }


// 5. Напишите программу, которая на вход принимает одно 
// чило (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());

// int numberNeg=number*-1;

// while(numberNeg<=number)
// {
//     Console.WriteLine(numberNeg);
//     numberNeg=numberNeg+1;
// }


// 7. Напишите программу, которая принимает на вход
// трехзначное чило и на выходе показывает последнюю 
// цифру этого числа. 456 -> 6     782 -> 2     918 -> 8


Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());

int result7=number%10;

Console.WriteLine(result7);

