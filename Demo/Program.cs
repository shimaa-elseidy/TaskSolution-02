using System.Text;
using System.Threading.Channels;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formating
            //String Formating 
            // 1. By Using String Concatination
            //Equation : X + Y = 12
            //int X = 2, Y = 3;
            //Console.WriteLine("Equation :" + " X" + " + " + "Y" + " = " + (X + Y));
            //String Has Aproblem That It Is Immutable ->   Meaning That U Can't Change Its Value After Creation
            // 2. By Using String Formating 
            //string Message = string.Format("Equation : X + Y = 12");
            //Console.WriteLine(Message);
            // Val By Position
            //string Result = String.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Result);
            // 3. String Interpolution [Syntax Sugar Best way]
            // $ ===> String Mainapulation
            //string Value = $"Equation : {X} + {Y} = {X + Y}";
            //Console.WriteLine(Value);
            #endregion
            //=========================================Control Statement================================
            // 1. Conditional Control Statement ===> If Statement Or Switch Case 
            // 2. Loop Control Statement        ===> For Or Foreach Or While Or do-while
            #region 1. Conditional Control Statement
            // 1. Conditional Control Statement ===> If Statement Or Switch Case 
            //Console.Write("Please, Enter Number Of Month In The 1st Quarter : ");
            //write or writeLine
            //int Month = int.Parse(Console.ReadLine());

            //if (Month == 1)
            //{
            //    Console.WriteLine("Jan");// If The User Enter 1
            //}
            //else if (Month == 2)
            //{
            //    Console.WriteLine("Feb");// If The User Enter 2
            //}
            //else if (Month == 3)
            //{
            //    Console.WriteLine("Mar");// If The User Enter 3 
            //}
            //else
            //{
            //    Console.WriteLine("Enter Valid Number!");
            //} 
            // Using Switch
            // Switch Create IN Run Time (Jump Table) ===> Best Performance
            //switch(Month)
            //{
            //    case 1 :
            //        Console.WriteLine("Jan");
            //    break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //    break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //    break;
            //    default:
            //        Console.WriteLine("Enter Valid Number");
            //    break;
            //}
            //Ex01
            //Console.WriteLine("Enter Ur Name : ");
            //string Name = Convert.ToString(Console.ReadLine());

            //if (Name=="Shimaa" | Name== "shimaa")
            //{
            //    Console.WriteLine("Hi, Shimaa");
            //}
            //else if (Name=="Mohamed" | Name=="mohamed")
            //{
            //    Console.WriteLine("Hi, Mohamed");
            //}
            //else
            //{
            //    Console.WriteLine("Hi, User");
            //}

            //switch(Name)
            //{
            //    case "Shimaa":
            //    case "shimaa":=======>meaning or 
            //        {
            //            Console.WriteLine("Hi, Shimaa");
            //        }
            //    break;
            //    case "Mohamed":
            //    case "mohamed":=======>meaning or
            //        {
            //            Console.WriteLine("Hi, Mohamed");
            //        }
            //    break;
            //    default:
            //        {
            //            Console.WriteLine("Hi, User");
            //        }
            //    break;
            //}
            //Ex02
            //Console.Write("Enter Ur Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //if (Age == 18 )
            //{
            //    Console.WriteLine("Hey U, Welcome To Our Team"); 
            //}
            //else if (Age>18)
            //{
            //    Console.WriteLine("Welcome :)");  
            //}
            //else if (Age<18)
            //{
            //    Console.WriteLine("Bye Bye ):");   
            //}
            //switch(Age)
            //{
            //case 18  :
            // Console.WriteLine("Hey U, Welcome To Our Team");
            //break;
            //case <18 :
            //  Console.WriteLine("Bye Bye ):");
            //break;
            //case >18 : 
            //  Console.WriteLine("Welcome :)");
            //break;

            //object Object = new object();
            //Object = "Shimaa";
            //Object = 3;
            //switch (Object)
            //{
            //    case int x when x < 2:
            //        Console.WriteLine("Hello");
            //        break;
            //    case string x when x.Length > 5:
            //        Console.WriteLine("Hey, Shimaa");
            //        break;
            //}
            // x here as ellyas name

            //string Input = Console.ReadLine();
            //string Output = Input switch
            //{
            //    "1" => " Option 1",
            //    "2" => " Option 2",
            //     _  => "Un Supported Option !!"
            //};
            //Console.WriteLine(Output);
            //Or
            //Console.WriteLine(Input switch
            //{
            //    "1" => " Option 1",
            //    "2" => " Option 2",
            //    _ => "Un Supported Option !!"
            //});
            //=> goes to then return value
            //_  (Discard) instead of default


            #endregion

            #region 2. Loop Control Statement
            // 2. Loop Control Statement        ===> For Or Foreach Or While Or do-while 
            //*** For Loop
            //for (int i = 9; i < 10; i++)
            //{
            //    Console.WriteLine("Hello Meshmesh");
            //}
            //int i = 1;
            //for (Console.WriteLine("hello"); i <= 2; Console.WriteLine("world"))
            //{
            //    Console.WriteLine("Hello Meshmesh");
            //    i++;
            //}
            // i refers to operator
            //*** Foreach
            //int[] Array = { 1, 2, 3, 4, 5 };
            //foreach (int item in Array)
            //{
            //    Console.WriteLine(item + item);
            //}
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Console.WriteLine(Array[i]);
            //}
            //*** While
            //int Age = 25;
            //while (Age==25)
            //{
            //    Console.WriteLine(Age); 
            //    //This Code Will Be Repeated While Condition "True"
            //}
            //int i = 2;
            //while (i <= 10)
            //{
            //    Console.WriteLine("SHIMAA");
            //    i++;
            //}
            //Console.WriteLine(i); // 11
            //*** Do-While
            //int i = 11;
            //do
            //{
            //    Console.WriteLine("meshmesh");
            //    //This Code Will Be Executed First
            //    i++;
            //}
            //while(i<=10);
            //Console.WriteLine(i);

            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.Write(" Even Number : ");
            //    Flag = int.TryParse(Console.ReadLine(),out Number);
            //}
            //while (Number % 2 != 0 || Flag == false);

            // Or
            //int Number;

            //do
            //{
            //    Console.Write(" Even Number : ");

            //}
            //while ( !int.TryParse(Console.ReadLine(), out Number) || Number % 2 != 0);

            #endregion
            #region String
            //String Refrence Type (Store in Heap) ==> Built In Class
            //Immutable Type => cam't change its value after creation
            //string S01;
            //Declare For Reference (Pointer) From Type String
            //S01 can refere to object from type string
            //refer to null
            //sore in stack but it has address in heap
            // 8 bytes will be allocated in stack for reference"S01"
            // 0 bytes will be allocated in Heap
            //S01 = new string("Shimaa");
            //S01 = "Shimaa";//Syntax Sugar
            //***New
            // 1.Allocate the number of required bytes for object at heap
            // 2.initialize the allocated bytes with default value
            // 3.call user defined constructor is exists
            // 4.Assign the object to reference
            //Console.WriteLine(S01.GetHashCode());//Id : Indicate to Address
            //string S02;
            //S02 = "Ali";
            //Console.WriteLine(S02.GetHashCode());
            #endregion
            #region String Builder
            //String Builder : Class Reference Type (Heap)
            //Mutable Data Type : can Change its value After Creation
            //StringBuilder S01;
            //Declare For Reference (Pointer) From Type StringBuilder
            //S01 can refere to object from type stringBuilder
            //refer to null
            //sore in stack but it has address in heap
            //S01 = new StringBuilder("ali");
            //Console.WriteLine(S01.GetHashCode());
            //S01.Append("Elseidy");
            // 1.Allocate the number of required bytes for object at heap
            // 2.initialize the allocated bytes with default value
            // 3.call user defined constructor is exists
            // 4.Assign the object to reference
            //Console.WriteLine(S01.GetHashCode());
            #endregion
            #region String Methods
            //string S01 = "Shimaa";
            //S01.Substring(3);
            //Console.WriteLine(S01);
            //string S01 = "Hello World";
            //var Result = S01.Replace("Hello", "Hey");
            //Console.WriteLine(Result);
            //string S01 = "Hello World";
            //bool Results = S01.StartsWith("H"); // Returns True Or False
            //Console.WriteLine(Results);
            //Can ignore Case Sensitave
            //string S01 = "hello World";
            //bool Results = S01.StartsWith("H",true, null); // Returns True Or False
            //Console.WriteLine(Results);
            //string S01 = "Hello World";
            //S01.ToCharArray();
            //var RESULT = S01.ToLower();
            //Console.WriteLine(RESULT);
            //string S01 = "Hello World";
            //var RESULT = S01.IndexOf("W");
            //Console.WriteLine(RESULT);
            //string Text = "Shimaa";
            //Console.WriteLine(Text.Length);
            //Console.WriteLine(Text.ToLower());
            //Console.WriteLine(Text.ToUpper());
            //Console.WriteLine(Text.Substring(0,4));
            //Console.WriteLine(Text.Contains("ma"));
            //string text = "3al,mho,mly";
            ///string[] parts = text.Split(',');
            //foreach (var part in parts)
            //{
            //    Console.WriteLine(part);
            //}
            //string Text = " Shimaa ";
            //Console.WriteLine(Text.Trim());//For Remove Spaces In The Start And The End
            //string Text = "Shimaa";
            //Console.WriteLine(Text.Remove(2,1));

            #endregion
        }
    }
}
