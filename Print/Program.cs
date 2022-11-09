// Как вывести на экран или в распечатку вводные данные, например массив

int[,] matrix = new int[,]
{
    {1, 9, 9},
    {0, 2, 8,},
    {0, 9, 0},
};

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} {" "}");
        }
    Console.WriteLine();
    }
}
PrintArray(matrix);