// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());

// int GetNaturNum1()
// {
   
//     int count = 1;

//     while(count<=num2)
//     {

//         num1= num1*count;
//         count++;
//     }
//     return num1;
// }
// int result = GetNaturNum1();
// Console.WriteLine(result);


// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {
//     int result = 0;
//     while(num>0)
//     {
//         result += num%10;
//         num = num/10;
//     }
//     return result;
// }
// Console.WriteLine(GetSumNum());


// Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];
GetArray();

void GetArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,100);
        Console.Write(array[i]+" ");
    }
}