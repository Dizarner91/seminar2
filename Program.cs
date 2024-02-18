// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;

class Program
{
    static bool IsDivisibleBy7And23(int number)
    {
        return (number % 7 == 0) && (number % 23 == 0);
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsDivisibleBy7And23(num))
        {
            Console.WriteLine($"{num} кратно и 7, и 23.");
        }
        else
        {
            Console.WriteLine($"{num} не кратно и 7, и 23.");
        }
    }
}

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки (X и Y):");
        
        // Считываем ввод пользователя и преобразуем его в целочисленные значения
        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // Проверяем в какой четверти находится точка
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвёртой координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка не находится ни в одной из координатных четвертей, так как одна или обе координаты равны нулю.");
        }
    }
}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую. -->
