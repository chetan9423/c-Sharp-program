namespace Logical_Program
{
    internal class Palindrome
    {
        static void Main()
        {
            Console.Write("Enter the number");
            int number =int.Parse(Console.ReadLine());

            int temp = number;
            int rem, Reverse = 0;
            while (number != 0)
            {
                rem = number % 10;
                Reverse = (Reverse * 10) + rem;
                number = number / 10;
            }
            
            if (temp == Reverse)
            {
                Console.WriteLine("Given number is palidrome");

            }
            else 
            {
                Console.WriteLine("Given number is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
