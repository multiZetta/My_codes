//Урок 3. Функции: продолжение



// Коды по лекции №3


// (МЕТОД 2) Если надо что-то вызвать. 
// Они не возвращают ничего, но принимают данные
// например, нам надо что-то вызвать в тексте text и сколько раз count

/* void Method2(string text, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(text);
        i++;
    }
}
Method2("1238", 2); */


// (МЕТОД 3) Что-то возвращает "return". Надо ввести тип данных, аргументы он не принимает
// 


/* int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */


// (МЕТОД 4) Что-то принимают и что-то возвращают
//например строку c "string text" компоновать друг за другом count раз
// 

/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   //  вот так еще можно ""  это обозначается пустая строка String.Empty
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(5, "Z");
Console.WriteLine(res); */

//  ЦИКЛ for
// например он пишется схематически так

/* for(int i= 0; i < 10; i++)
{
    Console.WriteLine(i)
}
 */

 
// Поправим пример из (МЕТОД 4)



/* string Method4(int count, string text)
{
    // int i = 0; убираем в for
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    //while (i < count) убираем в for
    {
        result = result + text;
        //i++; убираем в for
    }
    return result;
}
string res = Method4(5, "Z");
Console.WriteLine(res); */


// ЦИКЛ внутри ЦИКЛА
// Допустим надо закрасить область, есть строчки есть столбики
// надо пробежаться по столбикам и строчкам и что-то там делать

// например он пишется схематически так

/* for(int i = 0; i < 10; i++)          // перебор по строкам
{
   for(int j = 0; j < 10; j++)          // перебор по столбцам
   {
    Console.WriteLine(i*j)
   }
    Console.WriteLine()
}
 */

 // Сделаем на примере таблицы умножения
 // 
/* for(int i = 2; i <= 10; i++)
{
   for(int j = 0; j < 10; j++) 
   {
    Console.WriteLine($"{i} * {j} = {i*j}");   // это называется интерполяция строк
   }
    Console.WriteLine();   // просто пустая строка, чтобы отделить результаты
} */