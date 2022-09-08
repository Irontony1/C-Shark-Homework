//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int CalcPositive(int counter) // метод подсчета положительный чисел через рекурсию
{   
    Console.WriteLine("Введите число :");
    string inputText = Console.ReadLine();
    
    if(inputText == "стоп") return counter;
    else
    {
        int number = Convert.ToInt32(inputText);
            if( number > 0) return CalcPositive(counter+1);
        return CalcPositive(counter);
    }
}

Console.WriteLine("Для завершения введите слово 'стоп'");
int result = CalcPositive(0);
Console.WriteLine($"Количество положительных чисел = {result}");