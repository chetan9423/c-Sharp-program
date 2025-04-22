using System;

class ADArray
{
    static void Main()
    {
        int[] arr = { 54, 45, 46, 35, 32, 67, 67, 45, 98, 43, 65, 76, 8 };

        Console.WriteLine("Original Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Array.Sort(arr); // Sort in ascending order

        Console.WriteLine("Sorted Array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Array.Reverse(arr); // Reverse to get descending order

        Console.WriteLine("Reversed Array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
