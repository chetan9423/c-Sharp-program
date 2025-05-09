namespace Logical_Program
{
    internal class Neonnum
    {
        public bool Isneon(int num)
        {
            int sum = 0;
            int Square = 1;
            int Temp = num;
            Square = num * num;
            while (Square != 0)
            {
           
                int digit = Square % 10;
                sum += digit;
                Square /= 10;
            }
            if (Temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Neonnum n = new Neonnum();
            if(n.Isneon(num)==true)
            Console.WriteLine("neon");
            else
            {
                Console.WriteLine("not");
            }
        }
            

            
        
    }
}
