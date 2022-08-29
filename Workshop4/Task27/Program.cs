//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNumbers(int number)
{   int result = 0;
    while(number > 0)
    {
        int tmp = number % 10;
        result += tmp;
        number = number / 10;
    }

    return result;
}

Console.WriteLine("Здравствуйте, я сложу все цифры в числе");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(number));