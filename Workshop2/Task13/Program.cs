//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Здравствуйте, я программа по нахождению третьей цифры из числа");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
string strNumberN = Convert.ToString(numberN);
int lenght = strNumberN.Length;
if(lenght < 3)
{
    Console.Write("Введенное число не является трехзначным");
}
else 
{
    Console.Write("Третья цифра введенного числа - " + strNumberN[2]);
}