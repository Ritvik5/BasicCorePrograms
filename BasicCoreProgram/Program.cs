using System.Xml;

namespace BasicCoreProgram
{
    public class SwapTwoNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enyter Two Numbers to Swap ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swapping " + "a= " +a +", b= " +b);
        }

    }
}