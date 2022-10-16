// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int function ()
// {
//     int itog = 1;
//         for (int i = 0; i<b;i++)
//         {
//         itog =itog*a;
//         }
//         return itog;
// }
 
//  Console.WriteLine($"Число {a} в степени {b} = {function()}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число : ");
// int x = Convert.ToInt32(Console.ReadLine());
// int itog = 0;

// int Fun()
// {
//     int itog=0;
//     for (int i=0; x>0; i++)
//     {
//     itog=x%10+itog;
//     x=x/10;
//     }
//    return itog;
// }

//  Console.WriteLine($"Сумма всех цифр = {Fun()}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]






// // мин и макс 2х значений, их разность

// int MinMax (int x, int y)
// {
//     if (x>y) 
//     {
//         return x;
//     }
//     else 
//     {
//         return y;
//     }
// }
// int max1 = MinMax(3,6);
// int a1 = 7;
// int a2 = 9;
// int max2 = MinMax(a1,a2);
// Console.WriteLine($"{max1}-{max2}={max1-max2}");



// Задача 24. Напишите программу, которая принимает на вход
// число А и выдает сумму чисел от 1 до А.
// 7-> 28, 4->10, 8->36

// Console.Clear();
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int function ()
// {
//     int sum=0;
//     for (int i=0; i<=a; i++)
//     {
//         sum=sum+i;
//     }
//     return sum;
// }
// Console.WriteLine (function());



// Задача 28. Напишите программу, которая принимает на вход 
// число N и выдает произведение чисел от 1 до N
// 4-> 24, 5->120

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void Proiz (int n)
// {
//     int proiz = 1;
//     for (int i=1; i<= n;i++)
//     {
//         proiz=proiz*i;
//     }
//     Console.WriteLine(proiz);
// }
// Proiz(n);


// Задача 26. Напишите программу, которая принимает на вход 
// число и выдает количество цифр в числе
// 456->3, 78->2, 89126->5

// Console.Clear();
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int Fun ()
// {
//     int i = 0;
//     while (x>0)
//     {
//         x=x/10;
//         i++;
//     }
//     return i;
// }
// Console.WriteLine (Fun());



// Задача 30. Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном
// порядке. [1,0,1,1,0,1,0,0]

// Console.Clear();
// int[] array = new int[8];

// void FillArray(int[] array)// заполнение массива
// {
//     int length=array.Length;
//     for(int index=0; index<length; index++)
//     {
//         array[index]=new Random().Next(0,2);
//     }
// }

// void PrintArray (int [] print)
// {
//     int length=array.Length;
//     for(int index=0; index<length; index++)
//     {
//         Console.Write(print[index]);
//     }
// }

// FillArray(array);
// PrintArray(array);