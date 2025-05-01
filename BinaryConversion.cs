namespace Logical_Program
{
    internal class BinaryValue
    {
        static void Main()
        {

            Console.Write("Enter sthe number");
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[16];
            int i=0;
      
             while(number>0)
            { 
                arr[i] = number % 2;
                number = number / 2;
                i++;

            }
            Console.WriteLine("binary value of given number is ");
            for (i=i-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();


        }
    }
}
