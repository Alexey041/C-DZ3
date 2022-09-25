//Напишите программу, которая принимает на вход число (N) и выдаёт
//таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число ");
int a = Math.Abs(int.Parse(Console.ReadLine()));
int count = 0;

while (count < a)
{
    count++;
    Console.Write($"{Math.Pow(count, 3)}");
    if (count != a)
        Console.Write(", ");
}
