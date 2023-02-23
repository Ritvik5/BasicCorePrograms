using System.Xml;

namespace BasicCoreProgram
{
    public class IsVowelConstant
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet to Check :");

            try
            {
                char alpha = Convert.ToChar(Console.ReadLine());
                switch(alpha)
                {
                    case 'a':
                        Console.WriteLine("The Character is Vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Character is Vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Character is Vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Character is Vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Character is Vowel");
                        break;
                        default: 
                        Console.WriteLine("The Character is Constant");
                        break;
                
                }
            }
            catch
            {
                Console.WriteLine("You have entered wrong input, please enter any character");
            }

            
        }

    }
}