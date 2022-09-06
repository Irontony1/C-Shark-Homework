//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] ReadConsole() // Метод считывания с консоли ряда чисел разделенных запятой
{
    Console.WriteLine("Введите числа через запятую:");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
    return array;
}

int CalcPositive(int[] array) // метод посчета кол-ва положительных чисел в массиве
{
    int size = array.Length;
    int counter = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] > 0) 
        counter += 1;
    }
    return counter;
}


int[] readArray= ReadConsole();
Console.WriteLine("[{0}]",string.Join(", ",readArray));
Console.WriteLine("Количество положительных чисел = " + CalcPositive(readArray));