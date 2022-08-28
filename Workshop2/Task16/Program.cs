//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Здравствуйте, я помогу разобраться в днях недели");
Console.Write("Введите цифру дня недели: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberN >= 1 && numberN <= 5)
{
    Console.Write("Будний день. Нужно на работу");
}
else if (numberN >= 6 && numberN <= 7)
{
    Console.Write("Выходной!!!");
}
else
{
    Console.Write("Такого дня недели нет");
}
