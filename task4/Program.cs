﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Введите число a: ");
         int a = int.Parse(Console.ReadLine()!);

         Console.Write("Введите число b: ");
         int b = int.Parse(Console.ReadLine()!);

         Console.Write("Введите число c: ");
         int c = int.Parse(Console.ReadLine()!);

         if(a >= b){
            if(a >= c){
                Console.WriteLine("max = " + a);
            }         
             else{
                Console.WriteLine("max = " + c);
            }
        }
         else{
            if(b >= c){
                Console.WriteLine("max = " + b);
            }
            else{
                Console.WriteLine("max = " + c);
            }

        }
    }
}
}
