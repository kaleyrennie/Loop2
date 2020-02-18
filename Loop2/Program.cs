using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pets do I have?");
            int pet = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {


                switch (pet)
                {

                    case 1:
                        Console.WriteLine("Correct! I have 1 pet.");
                        isGuessed = true;
                        break;
                    default:
                        Console.Write("You are wrong. ");
                        Console.Write("How many pets do I have?");
                        pet = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            Console.ReadLine();
        }
    }
}
