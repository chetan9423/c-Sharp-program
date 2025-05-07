namespace Logical_Program
{
    internal class missingValue
    {
        static void Main()
        {
            Console.Write("Enter the Array size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the Elemnt integer");
            for (int i = 0; i < num; i++)
            {
               
                    arr[i] = int.Parse(Console.ReadLine());
                }
            
            Array.Sort(arr);
            Console.WriteLine("the missing Element");
            for (int i = 0; i < num-1; i++)
            {
                for (int j = arr[i] + 1; j < arr[i + 1]; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
