//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Здравствуйте, проверим является ли пятизначное число палиндромом?");
Console.Write("Введите пятизначное число: ");
string numberN = Console.ReadLine();
Console.WriteLine(CheckPalindrome(numberN));

string CheckPalindrome(string str)
{
    int len = str.Length;
    
    if (len == 5)
    {
        if (str[0] == str[4] && str[1] == str[3])
            return "Это палиндром!";
        else 
            return "Это число не является палиндромом";

    }
    return "Введенное вами число не пятизначное";
    
}
