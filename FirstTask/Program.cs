// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
int degree = A;
for (int i = 1; i < B; i++)
{
    degree = degree * A;
}
Console.WriteLine("A в степени B равно: " + degree);