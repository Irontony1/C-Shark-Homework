//Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Здравствуйте, я программа по нахождению всех четных чисел в диапазоне [-N, N]");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = -numberN;

while(index < numberN+1)
{   
    if (index == numberN)
    {
        Console.Write(index);
    }
    else
    {
        Console.Write(index + ", ");} 
    index++;  
}