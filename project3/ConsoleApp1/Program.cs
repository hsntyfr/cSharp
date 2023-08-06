using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int arraySize = int.Parse(Console.ReadLine());
        
        //This while loop checks if the array size is valid
        while (arraySize <= 0)
        {
            Console.WriteLine("Invalid array size");
            Console.Write("Enter size of array: ");
            arraySize = int.Parse(Console.ReadLine());
        }
        
        int[] array = new int[arraySize];

        Console.WriteLine("Enter array elements:");
        
        //This for loop takes the array elements
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"0 --> {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        bool newOperation = false;

        while (newOperation != true)
        {
            Console.WriteLine("1 --> Select new indexes");
            Console.WriteLine("2 --> Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    WriteArray(array);
                    Console.Write("Enter start index: ");
                    int startIndex = int.Parse(Console.ReadLine());

                    Console.Write("Enter end index: ");
                    int endIndex = int.Parse(Console.ReadLine());

                    //This while loop checks if the start and end indexes are valid
                    while (startIndex < 0 || startIndex >= arraySize || endIndex < 0 || endIndex >= arraySize || startIndex > endIndex)
                    {
                        WriteArray(array);
                        Console.WriteLine("Invalid indexes");
                        Console.Write("Enter start index: ");
                        startIndex = int.Parse(Console.ReadLine());

                        Console.Write("Enter end index: ");
                        endIndex = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Sum of between ranges: {SumInRange(array, startIndex, endIndex)}");
                    Console.WriteLine($"Sum of before between ranges: {SumBeforeIndex(array, startIndex)}");
                    Console.WriteLine($"Sum of after between ranges: {SumAfterIndex(array, endIndex)}");
                    break;
                
                case 2:
                    newOperation = true;
                    break;
            }
        }
    }
    
    static int SumInRange(int[] arr, int start, int end)
    {
        int sumInRange = 0;
        
        //This for loop sums the elements between the start and end indexes
        for (int i = start; i <= end; i++)
        {
            sumInRange += arr[i];
        }
        return sumInRange;
    }

    static int SumBeforeIndex(int[] arr, int index)
    {
        int sumBeforeIndex = 0;
        
        //This for loop sums the elements before the start index
        for (int i = 0; i < index; i++)
        {
            sumBeforeIndex += arr[i];
        }
        return sumBeforeIndex;
    }

    static int SumAfterIndex(int[] arr, int index)
    {
        int sumAfterIndex = 0;
        
        //This for loop sums the elements after the end index
        for (int i = index + 1; i < arr.Length; i++)
        {
            sumAfterIndex += arr[i];
        }
        return sumAfterIndex;
    }

    static void WriteArray(Array array)
    {
        Console.Write("Array elements: ");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
