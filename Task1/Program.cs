// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

Console.Clear();
Console.Write( "введите трехзначное число  ");
int number = int.Parse(Console.ReadLine());

int first_symbol = number/100;
Console.WriteLine(number/100);

int midle_symbol = number%100/10;
Console.WriteLine(number%100/10);

int last_symbol = number%10;
Console.WriteLine(number%10);
Console.WriteLine($"Вторая цифра числа {number} это {midle_symbol} ");


