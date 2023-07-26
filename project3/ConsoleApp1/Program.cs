using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int arraySize = int.Parse(Console.ReadLine());
        
        while (arraySize <= 0)
        {
            Console.WriteLine("Invalid array size");
            Console.Write("Enter size of array: ");
            arraySize = int.Parse(Console.ReadLine());
        }
        
        int[] array = new int[arraySize];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"0 --> {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter start index: ");
        int startIndex = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int endIndex = int.Parse(Console.ReadLine());

        while (startIndex < 0 || startIndex >= arraySize || endIndex < 0 || endIndex >= arraySize)
        {
            Console.WriteLine("Invalid indexes");
            Console.Write("Enter start index: ");
            startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter end index: ");
            endIndex = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum of between ranges: {SumInRange(array, startIndex, endIndex)}");
        Console.WriteLine($"Sum of before between ranges: {SumBeforeIndex(array, startIndex)}");
        Console.WriteLine($"Sum of after between ranges: {SumAfterIndex(array, endIndex)}");
    }

    static int SumInRange(int[] arr, int start, int end)
    {
        int sumInRange = 0;
        for (int i = start; i <= end; i++)
        {
            sumInRange += arr[i];
        }
        return sumInRange;
    }

    static int SumBeforeIndex(int[] arr, int index)
    {
        int sumBeforeIndex = 0;
        for (int i = 0; i < index; i++)
        {
            sumBeforeIndex += arr[i];
        }
        return sumBeforeIndex;
    }

    static int SumAfterIndex(int[] arr, int index)
    {
        int sumAfterIndex = 0;
        for (int i = index + 1; i < arr.Length; i++)
        {
            sumAfterIndex += arr[i];
        }
        return sumAfterIndex;
    }
}
