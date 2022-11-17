// Чтобы избавиться от большого количества переменных, для этого
// понадобятся массивы. Скопируем код из V 3. из папки  Ex006_max9 
// и будем с ним работать

// ТИП ДАННЫХ[] ИМЯ = {Значение1,Значение2, ...}
// int[] array = { 9, 28, 1, 32, 1990 }
// int[] array = { 0, 0, 0, 0, 0 }
// int[] array = new int[5];
// int[] array = new int[]{ 0, 0, 0, 0, 0 }
// int[] array = new int[5]{ 1, 0, 2, 0, 3 }

// работаем с кодом из V 3. из папки  Ex006_max9 
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}//     индекс  0    1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(
 Max(array[0], array[1], array[2]),
 Max(array[3], array[4], array[5]),
 Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

