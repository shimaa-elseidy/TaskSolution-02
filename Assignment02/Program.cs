using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Region01
            // 1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 3 == 0 && Num % 4 == 0) 
            //{
            //    Console.WriteLine("Yess");
            //}
            //else 
            //{
            //    Console.WriteLine("No");
            //}; 
            #endregion
            #region Region2
            //2 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //  Console.Write("Enter The Number: ");
            //  int Number = int.Parse(Console.ReadLine());
            //  if (Number < 0)
            //     {
            //    Console.WriteLine("Negative");
            //    }
            //else
            //    {
            //    Console.WriteLine("Positive");
            //    } 
            #endregion
            #region Region03
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //int maxElement = int.MinValue;  
            //int minElement = int.MaxValue;   

            //Console.WriteLine("Enter three integers (one per line):");

            //for (int i = 0; i < 3; i++)
            //{

            //    int number = int.Parse(Console.ReadLine());
            //    if (number > maxElement)
            //    {
            //        maxElement = number;
            //    }

            //    else if (number < minElement)
            //    {
            //        minElement = number;
            //    }
            //}
            //Console.WriteLine($"Max element = {maxElement}");
            //Console.WriteLine($"Min element = {minElement}");

            //**** Another Solution Using math();
            //Console.WriteLine("Enter three integers (one per line):");

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int maxValue = Math.Max(num1, Math.Max(num2, num3));
            //int minValue = Math.Min(num1, Math.Min(num2, num3)); 
            //Console.WriteLine($"Maximum Value: {maxValue}");
            //Console.WriteLine($"Minimum Value: {minValue}"); 
            #endregion
            #region Region04
            // 4- Write a program that allows the user to insert an integer number then check If a number is even or odd. 
            //Console.WriteLine("Enter An Integer Number : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("The Number Is Even");
            //}
            //else if (num %2 != 0)
            //{
            //    Console.WriteLine("The Number Is Odd");
            //} 
            #endregion
            #region Region05
            /* 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then
               print (vowel) otherwise print (consonant).*/

            //Console.WriteLine("Enter The Character");
            //char Input  = Console.ReadLine()[0];
            //char LowerInput = char.ToLower(Input);
            //if (!char.IsLetter(LowerInput))
            //{
            //    Console.WriteLine("The input is not a valid letter. Please enter a letter.");
            //    return;
            //}

            //if (LowerInput == 'a' || LowerInput == 'e' || LowerInput == 'i' || LowerInput == 'o' || LowerInput == 'u')
            //{
            //    Console.WriteLine("The Character Is Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("The CHaracter Is Consonant");
            //} 
            #endregion
            #region Region06
            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //console.write("insert an integer number : ");
            //int num = int.parse( console.readline());
            //for (int i = 1; i <+ num; i++)
            //{
            //    console.writeline(i);
            //}
            #endregion
            #region Region07
            /*  7 - Write a program that allows the user to insert an integer then
                  print a multiplication table up to 12
            */
            //Console.Write("Enter An Integer Number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"multiplication Table for {input} : ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = input*i;
            //    Console.WriteLine(result);
            //}
            #endregion
            #region Region08
            // 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Insert An Number : ");
            //int Input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Even numbers between 1 and {Input}:");
            //for (int i = 1; i <= Input; i++)
            //    {
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    }
            #endregion
            #region Region09
            // 9- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Insert Two Integers : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //double result = Math.Pow(num1,num2);
            //Console.WriteLine(result);
            #endregion
            #region Region10
            // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int TotalMarks = 0; 
            //int maxMarksPerSubject = 100; 

            //Console.WriteLine("Enter Marks Of Five Subjects (Line By Line, Please): ");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Subject {i}: ");
            //    int marks = int.Parse(Console.ReadLine());
            //    TotalMarks += marks;
            //}
            //double averageMarks = (double)TotalMarks / 5;
            //double percentage   = (double)TotalMarks / (5 * maxMarksPerSubject) * 100;

            //Console.WriteLine($"\nTotal Marks: {TotalMarks}");
            //Console.WriteLine($"Average Marks: {averageMarks}");
            //Console.WriteLine($"Percentage:    {percentage}%");
            #endregion
            #region Region11
            //11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter The Month Number(1-12) : ");
            //int month = int.Parse(Console.ReadLine());
            //int days;
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //            days = 31;
            //            Console.WriteLine($"Month {month} has {days} days.");
            //        break;
            //    case 2:
            //            days = 28;
            //        Console.WriteLine($"Month {month} has {days} days .");
            //        break;
            //    case 4: 
            //    case 6: 
            //    case 9: 
            //    case 11: 
            //           days = 30;
            //        Console.WriteLine($"Month {month} has {days} days.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number! Please enter a number between 1 and 12.");
            //        break;
            //}

            #endregion
            #region Region12
            //12 - Write a program to create a Simple Calculator.
            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2;
            //int sub = num1 - num2;
            //int mul = num2 * num1;
            //double div = (num2 !=0) ? (double) num1 % num2 :0  ;
            //Console.WriteLine($"Sum : {sum}");
            //Console.WriteLine($"Sub : {sub}");
            //Console.WriteLine($"Mul : {mul}");
            //if (num2 != 0)
            //{
            //    Console.WriteLine($"Div: {div}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            #endregion
            #region Region13
            // 13 - Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter A String : ");
            //string Text =  Console.ReadLine() ;
            //string ReversedText = new string( Text.Reverse().ToArray());
            //Console.WriteLine($"Reversed string: {ReversedText}");
            #endregion
            #region Region14
            // 14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter An Integer : ");
            //int Integer = int.Parse(Console.ReadLine());
            //string ReversedInteger = new string( Integer.ToString().Reverse().ToArray());
            //Console.WriteLine($"Reversed integer: {ReversedInteger}");
            #endregion
            #region Region15
            // 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //   Console.WriteLine("Input starting number of range: ");
            //   int start = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Input ending number of range: ");
            //    int end = int.Parse(Console.ReadLine());
            //    bool primeNum = true;
            //Console.WriteLine($"The prime numbers between {start} and {end} are:");

            //    for (int i = start; i <= end; i++)
            //    {
            //        for (int incre = 2; incre <= Math.Sqrt(i); incre++) 
            //        {
            //            if (i % incre == 0)
            //            {
            //                primeNum = false;
            //                break;
            //            }
            //        }
            //        if (primeNum)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            #endregion
            #region Region16
            // 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = ""; 
            //while (number > 0)
            //{
            //    binary = (number % 2) + binary;
            //    number = number / 2; 
            //}

            //Console.WriteLine($"The Binary of the number is {binary}");

            #endregion
            #region Region17
            /*
            17- Create a program that asks the user to input three points (x1, y1),
            (x2, y2), and (x3, y3), and 
            determines whether these points lie on a single straight line.
            */
            //Console.Write("Enter the x-coordinate of the first point (x1): ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the y-coordinate of the first point (y1): ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the x-coordinate of the second point (x2): ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the y-coordinate of the second point (y2): ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the x-coordinate of the third point (x3): ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the y-coordinate of the third point (y3): ");
            //double y3 = double.Parse(Console.ReadLine());

            //bool areCollinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

            //if (areCollinear)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion
            #region Region18
            /*
            18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */
                //Console.Write("Enter the time (in hours) taken by the worker to complete the task: ");
                //double timeTaken = double.Parse(Console.ReadLine());
                //if (timeTaken >= 2 && timeTaken <= 3)
                //{
                //    Console.WriteLine("The worker is highly efficient.");
                //}
                //else if (timeTaken > 3 && timeTaken <= 4)
                //{
                //    Console.WriteLine("The worker needs to improve their speed.");
                //}
                //else if (timeTaken > 4 && timeTaken <= 5)
                //{
                //    Console.WriteLine("The worker needs training to enhance their speed.");
                //}
                //else if (timeTaken > 5)
                //{
                //    Console.WriteLine("The worker must leave the company.");
                //}
                //else
                //{
                //    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
                //}
        #endregion

    }
}

    }
    

