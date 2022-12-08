// // Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5
int[] CreateArray(int length, int minRange, int maxRange)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}
int rand = 1;
int max1 = 0;
int max2 = 0;
while(rand == 0)
{
    if (rand >=max1){
        max2 = max1;
        max1 = rand;
    }
    
}
System.Console.WriteLine(max2);

System.Console.WriteLine("Задача не получилась у меня :(");

