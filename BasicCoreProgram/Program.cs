using System.Xml;

namespace BasicCoreProgram
{
    public class IsEvenOdd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enyter Any Number to Check its Even or Odd ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if(a % 2 == 0 )
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

    }
}