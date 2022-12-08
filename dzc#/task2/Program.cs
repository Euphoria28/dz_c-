int number;
System.Console.WriteLine("Введите число > ");
number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number/10;
}
System.Console.WriteLine("Сумма цифр в числе: ");
Console.WriteLine(sum);