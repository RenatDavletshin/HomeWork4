// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число: ");
int count = int.Parse(Console.ReadLine());
int sum = 0;

while (count > 0)
{
    sum += count % 10; 
    count /= 10;
}
Console.WriteLine($"Сумма всех цифр в числе равна: {sum}");