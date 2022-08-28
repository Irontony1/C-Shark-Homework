//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Здравствуйте, я программа по вычислению длины отрезка в трехмерном пространстве");
int[] numberA = new int[3];
int[] numberB = new int[3];
Console.WriteLine("Введите координаты точки A:");
Console.Write(" x = ");
numberA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write(" y = ");
numberA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write(" z = ");
numberA[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write(" x = ");
numberB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write(" y = ");
numberB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write(" z = ");
numberB[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина вектора составляет - "+ VectorLength(numberA,numberB));

double VectorLength(int[] arrayA, int[] arrayB)
{
    double longNumber = Math.Sqrt(Math.Pow(arrayB[0]-arrayA[0],2)+Math.Pow(arrayB[1]-arrayA[1],2)+Math.Pow(arrayB[2]-arrayA[2],2));
    return Math.Truncate(100 * longNumber)/100;
}