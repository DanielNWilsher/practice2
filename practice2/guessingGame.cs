using System;
using System.Linq;

namespace practice2
{
    public class guessingGame
    {
        public guessingGame()
        {
            Console.WriteLine("enter a number between 0 and 100");
            int YourNumber = Convert.ToInt32(Console.ReadLine());
            int Max = 100;
            int Min = 0;
            bool ItAintOver = false;
            while (ItAintOver == false) {
                var Result = BinaryChop(Min, Max, YourNumber);
                if (Result == true)
                {
                    ItAintOver = true;
                }
            }
        }

        static bool BinaryChop(int Min, int Max, int YourNumber)
        {
            int Median = 0;
            bool KeepItUp = false;
            while (KeepItUp == false)
            {
                while (Median != YourNumber)
                {
                    int AddItUp = Min + Max;
                    int Chop = AddItUp / 2;
                    Console.WriteLine("is your number higher or lower than: " + Chop);
                    Console.WriteLine("Enter 1 if your number is higher or Enter 2 if your number is lower");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Min = Chop;
                            Console.WriteLine(Min);
                            Median = Chop;
                            break;
                        case 2:
                            Max = Chop;
                            Console.WriteLine(Max);
                            Median = Chop;
                            break;
                            
                    }
                    Median = Chop;
                }
                Console.WriteLine("Your number is: " + YourNumber);
                KeepItUp = true;
                
            }
            var Result = true;
            return Result;
        }
    }
}
