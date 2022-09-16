//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int PrintSum(int min, int max)
{   
    if( min < max ) 
    {   
        Console.Write($"{min},");
        return min + PrintSum(++min, max);
    }
        if( min > max ) 
    {   
        Console.Write($"{min},");
        return min + PrintSum(--min, max);
    }
    else 
    {   
        Console.Write($"{min}");
        return min;
    }
}

Console.WriteLine("Введите число начала :");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конца :");
int max = int.Parse(Console.ReadLine());

int sumNumbers = PrintSum(min, max);
Console.WriteLine($" - сумма этих равна {sumNumbers}");