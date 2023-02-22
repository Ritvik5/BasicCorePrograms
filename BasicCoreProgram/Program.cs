using System.Xml;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            

            for (int p = 2; p <= number; p++)
            {
                while (number % p == 0)
                {
                    Console.WriteLine(p);
                    number = number / p;
                }
                
            }
        }

    }
}