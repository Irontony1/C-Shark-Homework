//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Здравствуйте, я программа по нахождению второй цифры из числа");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
string strNumberN = Convert.ToString(numberN);
Console.Write("Вторая цифра числа введенного числа - " + strNumberN[1]);
