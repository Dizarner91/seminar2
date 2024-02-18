// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число:");
//         string input = Console.ReadLine();

//         int number; 
//         if (int.TryParse(input, out number))
//         {
//             if (number % 7 == 0 && number % 23 == 0)
//             {
//                 Console.WriteLine($"{number} кратно и 7, и 23.");
//             }
//             else
//             {
//                 Console.WriteLine($"{number} не кратно и 7, и 23.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: Введите корректное целое число.");
//         }
//     }
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");
        
        
//         Console.Write("X: ");
//         int x = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Y: ");
//         int y = Convert.ToInt32(Console.ReadLine());

        
//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится в первой координатной четверти.");
//         }
//         else if (x < 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится во второй координатной четверти.");
//         }
//         else if (x < 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в третьей координатной четверти.");
//         }
//         else if (x > 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в четвёртой координатной четверти.");
//         }
//         else
//         {
//             Console.WriteLine("Точка не находится ни в одной из координатных четвертей, так как одна или обе координаты равны нулю.");
//         }
//     }
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число из отрезка [10, 99]:");
        string input = Console.ReadLine();

        int number;

        if (int.TryParse(input, out number))
        {
            if (number >= 10 && number <= 99)
            {
                int firstDigit = number / 10; 
                int secondDigit = number % 10;

                int maxDigit = Math.Max(firstDigit, secondDigit);

                Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите целое число из отрезка [10, 99].");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
    }
}


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую. -->
