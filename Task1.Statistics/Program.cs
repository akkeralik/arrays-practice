using System;
Random random = new Random();
int[] numbers = new int[10];
int sum = 0; 
double product = 1;
int evenCount = 0;
for (int i =0; i<numbers.Length; i++)
{
    numbers[i] = random.Next(1, 101);
    sum = sum + numbers[i];
    product = product * numbers[i];

    if (numbers[i]%2==0)
    {
        evenCount++
    }
}
double average = (double)sum/numbers.Length;
int aboveAverageCount = 0;
for (int i = 0; i<numbers.Length; i++)
{
    if (numbers[i]>average)
    {
        aboveAverageCount++;
    }
}

Console.WriteLine("Массив: " + string.Join(", ", numbers));
Console.WriteLine("Сумма: "+sum);
Console.WriteLine("Произведение: "+product);
Console.WriteLine("Четных чисел: "+evenCount);
Console.WriteLine("Больше среднего "+average+"): "+abiveAverageCount);
