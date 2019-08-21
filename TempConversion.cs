using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class TempConversion
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                float temp = GetNumber("Enter a temperature to convert, or enter -40 to quit: ");

                if (temp == -40)
                {
                    break;
                }

                string conversion = GetInput("Enter CtoF to convert from Celsius to Fahrenheit \nEnter FtoC to convert from Fahrenheit to Celsius.");

                ConvertTemp(conversion, temp);
            } 
        }
        static void ConvertTemp(string convertTo, float temperature)
        {
            float convertedTemp;
            switch (convertTo)
            {
                case "CtoF":
                    convertedTemp = ((temperature * 9) / 5) + 32;
                    Console.WriteLine("The temperature in Fahrenheit is: {0}", convertedTemp);
                    break;

                case "FtoC":
                    convertedTemp = (temperature - 32) * 5 / 9;
                    Console.WriteLine("The temperature in Celsius is: {0}", convertedTemp);
                    break;

                default:
                    break;
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string str = Console.ReadLine();
            return str;
        }   

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }
    }
}
