/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] arrayM = new int[m];
int sum = 0;
void Array (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (0); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
            Console.WriteLine (matrix [i,j] + "\t");
        }
        Console.WriteLine();
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix [i,j];
            arrayM [j] = sum;
        }
        sum = 0;
    }
}
Array(matrix);
Console.WriteLine();
Console.WriteLine(string.Join("\t", arrayM));
