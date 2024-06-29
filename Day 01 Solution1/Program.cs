using System.Data.SqlTypes;

namespace Day_01_Solution1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 2

            #region  Q1 
            //Write a program that allows the user to enter a number then print it.

            //int Number;
            //Console.WriteLine("Enter a Number");
            //Number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your Nomber Is {Number}");
            #endregion

            #region Q2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string number = "123abc";
            //int result = Convert.ToInt32(number);
            #endregion

            #region Q3 
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


            //double num1 = 0.1;
            //double num2 = 0.2;
            //double sum = num1 + num2;

            //Console.WriteLine($"The Result = {sum}");

            #endregion

            #region Q4 
            //Write C# program that Extract a substring from a given string.

            //string input = "Hello, World!";
            //string subString = input.Substring(7, 5);
            //Console.WriteLine($"The SubString = {subString}");

            #endregion

            #region Q5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int X = 1;
            //int Y = 2;

            //Console.WriteLine($"X = {X} , Y = {Y}");
            //Console.WriteLine("-------------------------");
            //Y = X;
            //Y = 5;

            //Console.WriteLine($"X = {X} , Y = {Y}");


            #endregion

            #region Q6 
            // Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = arr1;
            //arr2[1] = 100;

            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);
            #endregion

            #region Q7 
            //Write C# program that take two string variables and print them as one variable

            //string Word1 = "Hello, ";
            //string Word2 = "World!";

            //Console.WriteLine($"{Word1} {Word2}");

            #endregion

            #region Q8
            // Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //double principal = 1000.0;
            //double rate = 6.0;
            //double time = 3.0;
            //double Interest = (principal * rate * time) / 100;

            //Console.WriteLine($"Simple Interest: {Interest}");
            #endregion

            #region Q9
            // Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //double Weight = 80.0;
            //double Height = 1.80;
            //double BMI = Weight / (Height * Height);

            //Console.WriteLine($"BMI: {BMI}");
            #endregion

            #region Q10
            // Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result.Assume that below 10 degrees is "Too Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //double Temperature = 25.0;
            //string TempCheck = Temperature < 10 ? "Too Cold" : (Temperature > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine($"Temperature IS: {TempCheck}");
            #endregion

            #region Q11
            //11 - Write a program that takes the date from user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //-------------------------------

            //DateTime CurrentDate = DateTime.Now;
            //string FormattedDate01 = $"Today’s date : {CurrentDate.Day},{CurrentDate.Month},{CurrentDate.Year}";
            //string FormattedDate02 = $"Today’s date : {CurrentDate.Day}/{CurrentDate.Month}/{CurrentDate.Year}";
            //string FormattedDate03 = $"Today’s date : {CurrentDate.Day}-{CurrentDate.Month}-{CurrentDate.Year}";


            //Console.WriteLine(FormattedDate01);
            //Console.WriteLine(FormattedDate02);
            //Console.WriteLine(FormattedDate03);
            #endregion

            #region Q12
            //What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            ////a) The event is on 14/06/2024
            ////b) The event is on 2024-06-14
            ////c) The event is on 06/14/2024
            ////d) The event is on June 14, 2024

            //// The correct statement is:
            //// Ansewr --> C
            //// c  The event is on 06/14/2024
            #endregion

            #region Q13
            //Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);


            //// The correct statement is:
            ///// Ansewr --> f
            //// A value 1 will be assigned to d.
            //// This is because !(30 < 20) evaluates to true, and Convert.ToInt32(true) returns 1.

            #endregion

            #region Q14
            //Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            //// The correct output is:
            ///// Answer --> d
            //// 6 1
            //// 13 / 2 = 6 and 13 % 2 = 1

            #endregion

            #region Q15
            //What will be the output of the C# code given below?

            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            //// The correct output is:
            ///// Answer --> D
            //// 7 7
            //// ++num is 2, z++ is 5, making it 7, and ++z is 7.

            #endregion

            #endregion
        }
    }
}
