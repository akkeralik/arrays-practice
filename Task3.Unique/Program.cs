using System;
class Program
{
    public static int[] GetUnique(int[] source)
    {
        int[] temp = new int[source.Length];
        int count = 0;

        for (int i=0; i<source.Length; i++)
        {
            int found = 0;

            for (int j = 0; j < count; j++)
            {
                if (source[i] == temp[j])
                {
                    found = 1;
                }
            }
            if (found == 0)
            {
                temp[count] = source[i];
                count++;
            }
        }
        int[] result = new int[count];
        for (int i = 0; i<count; i++)
        {
            result[i] = temp[i];
        }
        return result;
    }
    static void Main()
    {
        int[] numbers = {1, 2, 2, 3, 4, 4, 5};
        Console.WriteLine("Исходный: "+string.Join(", ", numbers));
        int[] unique = GetUnique(numbers);
        Console.WriteLine("Уникальные: "+string.Join(", ", unique));
    }
}
