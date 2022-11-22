/*
 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 a = 5; b = 7 -> max = 7
 a = 2 b = 10 -> max = 10
 a = -9 b = -3 -> max = -3
 */

 Console.WriteLine("Первое число: ");
 int oneNumber = Int16.Parse(Console.ReadLine() ?? "");
 Console.WriteLine("Второе число: ");
int twoNumber = Int16.Parse(Console.ReadLine() ?? "");
if (oneNumber > twoNumber) {
    Console.WriteLine($"{oneNumber} more {twoNumber}");
} else {
    Console.WriteLine($"{twoNumber} more {oneNumber}");
}

/*
 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 2, 3, 7 -> 7
 44 5 78 -> 78
 22 3 9 -> 22
 */

Console.WriteLine("Первое число: ");
int numberOne = Int16.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Второе число: ");
int numberTwo = Int16.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Третье число: ");
int numberThree = Int16.Parse(Console.ReadLine() ?? "");
int maxNumber = numberOne;

if (numberTwo > maxNumber) {
    maxNumber = numberTwo;
}
if (numberThree > maxNumber) {
    maxNumber = numberThree;
}
Console.WriteLine($"MaxNumber = {maxNumber}");

/*
 Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 4 -> да
 -3 -> нет
 7 -> нет
*/

Console.WriteLine("Введите число: ");
int number = Int16.Parse(Console.ReadLine() ?? "");
if (number % 2 == 0) {
    Console.WriteLine($"{number} - четное число");
} else {
    Console.WriteLine($"{number} - нечетное число");
}

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 5 -> 2, 4
 8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int num = Int16.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0) {
        Console.WriteLine($"{i}");
    }
}
