// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввод первого числа: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввод второго числа: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)

Console.WriteLine("Максимальное число: " + Number1);
    else
    {
        Console.WriteLine("Максимальное число: " + Number2);
    }