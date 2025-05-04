using System;

namespace Logical_Program
{
    internal class Insertion
    {
        static void Main()
        {
            Console.WriteLine("Enter the array size:");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num + 1];

            Console.WriteLine("Enter the original array elements:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the position to insert");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter the element to insert: ");
            int element = int.Parse(Console.ReadLine());

            
            for (int i = num; i > position - 1; i--)
            {
                arr[i] = arr[i - 1];
            }

           
            arr[position - 1] = element;

            Console.WriteLine("Array after insertion:");
            for (int i = 0; i < num + 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
