//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Здравствуйте, я программа для поиска большего и меньшего числа");
Console.Write("Введите первое число (a): ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Большее число " + numberA);
    Console.WriteLine("Меньшее число " + numberB);
}
else if(numberA < numberB)
{
    Console.WriteLine("Большее число " + numberB);
    Console.WriteLine("Меньшее число " + numberA);
}