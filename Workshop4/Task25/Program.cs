//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double LevelNumber(int number, int level)
{
    return Math.Pow( number,level );
}


Console.WriteLine("Здравствуйте, я помогу возвести число в степень");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести: ");
int lvl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получилось : " + LevelNumber( number,lvl ));
