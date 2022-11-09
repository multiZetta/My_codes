
// Например
// сколько раз встречается тот или иной элемент (надо доделать до конца!)


string Solve(int[] dataNumbers)
{
    if (dataNumbers.Length == 0) return "пусто было";
    string output = String.Empty;
    int max = dataNumbers[0];               // назначаем максимальное значение в массиве и делаем сравнения с ним
    for (int i = 0; i < dataNumbers.Length; i++)
    {
        if (dataNumbers[i] > max) max = dataNumbers[i];   // ищем максимальное число
    }
    int[] result = new int[max + 1];   // выводим результат в новый массив с большим размером чем предыдущий на 1

    for (int i = 0; i < dataNumbers.Length; i++)
    {
        result[dataNumbers[i]]++;    // считаем сколько раз попадаются одинаковые значения
    }

    for (int i = 0; i < result.Length; i++)   // ищем в новом массиве
    {
        if (result[i] != 0)
        {
            output += $"{i} - {result[i]} р.\n";   // {i} значение - {result[i]} р. сколько  р. это раз
        }
    }
    return output;
}

