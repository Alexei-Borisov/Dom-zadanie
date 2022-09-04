//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine ("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе неатрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int f (int m, int n)
{
    if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return f (n - 1, 1);
    else
      return f (n - 1, f (n, m - 1));
}

Console.WriteLine (f(m, n));

