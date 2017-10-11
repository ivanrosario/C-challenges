using System;

namespace WeeklyChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string userNum;
            int result;

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter a Number..");
            userNum = Console.ReadLine();

            Int32.TryParse(userNum, out result);

            if(result >= 10 )
            {
				Console.BackgroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("This number is big enough");

            }else
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("This number is not big enough");
            }

        }
    }
}



//EASY: Create a program that asks the user to enter an integer.If the integer is less than 10, print the message "This number is too small". If the integer is greater than or equal to 10, print "This number is big enough".  
//Hint: read a line and then use Int32.TryParse() to convert the text to an integer.
  