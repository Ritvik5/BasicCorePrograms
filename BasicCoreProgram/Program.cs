using System.Xml;

namespace BasicCoreProgram
{
    public class LargestOFThree
    {
        public static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            if (num1 > num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("Number one is Largest");

                }
                else
                {
                    Console.WriteLine("Number three is Largest");
                }
            }
            else if (num2 < num3)
            {
                Console.WriteLine("Number Two is Largest");
            }
            else
            {
                Console.WriteLine("Number three is Largest");
            }
        }
    }
}