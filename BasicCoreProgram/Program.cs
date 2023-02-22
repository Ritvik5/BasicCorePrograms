namespace BasicCoreProgram
{
    class Poweroftwo
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int multiplier;
            int result;

            for(multiplier = 1; multiplier <= 10; multiplier++)
            {
                result = number * multiplier;
                Console.WriteLine("{0} * {1} = {2}",number,multiplier,result);
            }
        }
    }
}