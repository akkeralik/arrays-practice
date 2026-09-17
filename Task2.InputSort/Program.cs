using System; 
int n = 0;
while (n<=0)
{
    try 
    {
      Console.Write("Введите количество элементов: ");
      n = int.Parse(Console.ReadLine());  
    }
    catch (FormatException) //буквы вместо числа
    {
        Console.WriteLine("Ошибка");
    }
    catch(OverflowException) //слишком большое число
    {
        Console.WriteLine("Ошибка");
    }
    
}
int[] numbers = new int[n];
for (int i = 0; i<numbers.Length; i++)
{
    try
    {
        Console.Write("Элемент [" + i + "]: ");
        numbers[i] = int.Parse(Console.ReadLine());  
    }
    catch (FormatException)
    {
        
        Console.WriteLine("Ошибка");
        i--; //при ошибке заставляет не переходить к некст элементу а еще раз запрашивает элемент
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка");
        i--; 
    }
}
Console.WriteLine("Исходный массив: "+string.Join(", ", numbers));

Console.Write("Обратный порядок: ");
for (int i = numbers.Length - 1; i>=0; i--)
{
    Console.Write(numbers[i]);
    if (i>0)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
Array.Sort(numbers); //переставляет числа от меньш к большему 
Console.WriteLine("По возрастанию: "+string.Join(", ", numbers));
Array.Reverse(numbers); //переставляет числа от большего к меньшему
Console.WriteLine("По убыванию: "+string.Join(", ", numbers));


