namespace Logical_Program
{
    internal class Calculator
    {
        public static int Add(int a, int b)
        {
           
            return a + b;
        }
        public int  Multiply(int a, int b)
        {
          
            return a * b;


        }
        static void Main()
        {
            Console.WriteLine("Enter the  number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calculator cal = new Calculator();
            Calculator.Add(a,b);
            cal.Multiply(a,b);
            Console.WriteLine($"Sum of {a + b}");
            Console.WriteLine($"multiply is {a * b}");
            Console.ReadLine();
        }


    }
}
