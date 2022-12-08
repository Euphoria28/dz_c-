// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

int First;
System.Console.WriteLine("Введите первое число: ");
First = Convert.ToInt32(Console.ReadLine());
int Second;
System.Console.WriteLine("Введите второе (натуральное) число:  ");
Second = Convert.ToInt32(Console.ReadLine());



if (Second > 0)
{
    System.Console.WriteLine($"Число {First} в натуральной степени {Second} :  ");
    System.Console.Write(Math.Pow(First,Second));
}

