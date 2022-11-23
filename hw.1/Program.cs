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

int MoreNumber (int first, int second) { 
    int result = 0;
    if (first > second) {
        result = first;
        Console.WriteLine($"{first} more {second}");
    } else {
        result = second;
        Console.WriteLine($"{second} more {first}");
    }
    return result;
};
int more = MoreNumber(
    oneNumber, twoNumber
);
Console.WriteLine(more);
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


int MaxNum(int one, int two, int three) {
     int maxNumber = one;
     if (two > maxNumber) {
         maxNumber = two;
     }
     if (three > maxNumber) {
         maxNumber = three;
     }
     
    return maxNumber;
};

int maxN = MaxNum(
    numberOne, numberTwo, numberThree
);
Console.WriteLine($"MaxNumber = {maxN}");
/*
 Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 4 -> да
 -3 -> нет
 7 -> нет
*/

Console.WriteLine("Введите число: ");
int number = Int16.Parse(Console.ReadLine() ?? "");
int ChetnNumber(int a) {
    int chetn = 0;
    if (number % 2 == 0) {
        Console.WriteLine($"{number} - четное число");
        
    } else {
        Console.WriteLine($"{number} - нечетное число");
        chetn = 1;
    }
    return chetn;
};

int taskChetn = ChetnNumber(
    4
);
Console.WriteLine(taskChetn);

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 5 -> 2, 4
 8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int num = Int16.Parse(Console.ReadLine() ?? "");

void AllNum(int num) {
for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0) {
        Console.WriteLine($"{i}");
    }
}
};
AllNum(
    5
);