//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Здравствуйте, я могу составить таблицу кубов от 1 до числа N");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

CubeNumber(numberN);

void CubeNumber(int numberN)
{
    int index=1;
    while(index<numberN+1)
    {
        Console.WriteLine(index + " - " + Math.Pow(index,3));
        index++;
    }
}