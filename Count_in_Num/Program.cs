

// Чтобы посчитать сколько цифр в числе.

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
    
    int result = 0;
    while (num > 0)    
    {
        result += 1;
        num = num / 10;
    }
Console.WriteLine(result);
