// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите число: ");
int len = int.Parse(Console.ReadLine());
int[]array = new int[len];
for (int i = 0; i < len; i++)
{
   array[i] = new Random().Next(len);
   Console.Write(array[i] + ", ");
}   
