/* Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 

// Создали двумерный массив случайных чисел от 1 до 1000. 
// С заданным от пользователя размером массива

//Условия для пользователя ввода с клавиатуры

Console.WriteLine("Двумерный массив будет заполнен рандомными числами до 1000 ");

Console.Write("Введите количество строк. ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов. ");
int n = Convert.ToInt32(Console.ReadLine());

// СТАНДАРТНЫЕ ШАГИ ДЛЯ СОЗДАНИЯ И ВЫВОДА В ПЕЧАТЬ 

//Cоздание двумерного массива.
int[,] matrix = new int[m, n];
matrix = FillArray(matrix);


// Заполнение двумерного массива.
int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 1000);
        }
    }
    return matrix;
}

//Печать массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
}
PrintArray(matrix);

// РЕШЕНИЕ задачи

Console.Write("Введите число до 1000, которое следует найти в массиве. ");
int x = Convert.ToInt32(Console.ReadLine());



void SearchArray(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (x == matrix[i, j])
            {
                Console.Write("Число" +" " + x + " " + "есть в данном массиве");
                count++;
            }
        }
    }
    if (count == 0) Console.Write("Такого числа нет в массиве.");
}

SearchArray(matrix); */

//==========================================================================================

