//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

if ((n >= 10000) & (n < 100000))
{
    int a = n % 10;
    int b = (n % 100) / 10;
    int c = (n % 10000) / 1000;
    int d = (n % 100000) / 10000;

    if ((a == d) & (b == c))
    {
        Console.WriteLine("Да");
    }

    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.Write("Число не пятизначное");
}