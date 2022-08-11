//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

Console.WriteLine ("[" + string.Join(", ", array) + "]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    count = count + array [i];
}
Console.WriteLine ("Сумма нечётных чисел" + count);


