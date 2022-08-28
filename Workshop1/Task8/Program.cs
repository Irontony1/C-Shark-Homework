//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Здравствуйте, я программа по нахождению всех четных чисел в диапазоне [1, N]");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(index < numberN+1)
{
    if (index % 2 == 0)
    {
        if (index == numberN)
        {Console.Write(index);
        }
        else
        {Console.Write(index + ", ");}
        
        index++;
    }
    else
    {
        index++;
    }
}