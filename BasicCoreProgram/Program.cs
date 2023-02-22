namespace BasicCoreProgram
{
    class HarmonicNumber
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            double harmonic = 0;

            for (int i = 1; i<= number; i++)
            {
                harmonic += 1.0 / i; //Or we can use (double)1 / i;
            }
            Console.WriteLine("The {0}th Harmonic number is {1}", number, harmonic);


        }
    }
}