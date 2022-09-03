//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine ("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе натуральное число, которое должно быть больше чем первое");
int n = Convert.ToInt32(Console.ReadLine());

int f (int m, int n)
{
    if (m == n)
        return n;
    return f (m + 1, n) + m;
}

Console.WriteLine (f(m, n));

