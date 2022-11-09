//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int row = 5;
int column = 5;
Console.WriteLine($"Размер массива {row}*{column}");
int[,] matrix = new int[row, column]; // иниц-ция массива
matrix = FillArray(matrix); // наполнение 
PrintArray(matrix); // вывод на экран

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//  РЕШЕНИЕ задачи

if (row != column)
{
    Console.WriteLine("Замена столбцов на строки в данном массиве невозможна ");
}
else
{
    int[,] newArray = new int[column, row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[j, i] = matrix[i, j];
        }
    }
    Console.WriteLine();
    PrintArray(newArray);
}
