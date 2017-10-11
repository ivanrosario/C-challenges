using System;

namespace WeeklyChallenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            string userInput;
            string choiceInput;

          
            Console.WriteLine("Enter a Number to convert..");

            userInput = Console.ReadLine();

            Int32.TryParse(userInput, out result);

			Console.WriteLine("Enter a Letter to convert.." +
                              "I -> convert from inches to centimeters.\n" +
                              "G -> convert from gallons to liters.\n" +
                              "M -> convert from mile to kilometer.\n" +
                              "P -> convert from pound to kilogram.");
            
			double  centimeter = 2.54;
			double  liters = 3.78;
			double kilometer = 1.6;
			double kilogram = 0.5;

            choiceInput = Console.ReadLine();

            switch(choiceInput.ToLower()){
                case "i":
                    double result1 = result * centimeter;
					Console.WriteLine(result1);
                    break;
                case "g":
                    double result2 = result * liters;

                    Console.WriteLine(result2);
                    break;
                case"m":
                    double result3 = result * kilometer;
					Console.WriteLine(result3);
                    break;
                case"p":
                    double result4 = result * kilogram;

                    Console.WriteLine(result4);
                    break;
                default:
					return ;



			}

		}
    }
}




//Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion.If user enters: 
//I -> convert from inches to centimeters.
//G -> convert from gallons to liters.
//M -> convert from mile to kilometer.
//P -> convert from pound to kilogram.
//If the user enters any other character then show a proper message.