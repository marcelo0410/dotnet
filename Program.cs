using System;
using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regex
            // Regex regexNumber = new Regex(@"[+-]?\d+\.?\d*");
            // Regex regexOperator = new Regex(@"[-+*/]");

            Regex regexString = new Regex(@"(\d+)\s*([-+*/])\s*(\d+)");
            // string s1 = "10 - 10";



            // number and operator
            int num1 = 0;
            int num2 = 0;
            String oper;
            string[] subs;



            // First number
            while(true)
            {
                Console.WriteLine("What do you want to calculate? (example: 10 - 10) ");
                String s1 = Console.ReadLine();
                // Match match = regexString.Match(s1);
                var match = regexString.Match(s1);
                if(match.Success)
                {
                    num1 = int.Parse(match.Groups[1].Value);
                    oper = match.Groups[2].Value;
                    num2 = int.Parse(match.Groups[3].Value);
                    
                    // subs = s1.Split(' ', '\t');
                    // num1 = Convert.ToInt32(subs[0]);
                    // oper = subs[1];
                    // num2 = Convert.ToInt32(subs[2]);
                    break;
                }
                Console.WriteLine("Please enter valid expression!");
            }
            

            // First number
            // while(true)
            // {
            //     Console.WriteLine("Enter first number: ");
            //     String s1 = Console.ReadLine();
                
            //     Match match = regexNumber.Match(s1);
            //     if(match.Success)
            //     {
            //         num1 = Convert.ToInt32(s1);
            //         break;
            //     } else
            //     {
            //         Console.WriteLine("Please enter valid number!");
            //     }
            // }

            // // Operator
            // while(true)
            // {
            //     Console.WriteLine("Enter operator: (+-*/) ");
            //     o1 = Console.ReadLine();
                
            //     Match match = regexOperator.Match(o1);
            //     if(match.Success)
            //     {
            //         break;
            //     } else
            //     {
            //         Console.WriteLine("Please enter valid operator!");
            //     }
            // }

            // // Second number
            // while(true)
            // {
            //     Console.WriteLine("Enter second number: ");
            //     String s2 = Console.ReadLine();
                
            //     Match match = regexNumber.Match(s2);
            //     if(match.Success)
            //     {
            //         num2 = Convert.ToInt32(s2);
            //         break;
            //     } else
            //     {
            //         Console.WriteLine("Please enter valid number!");
            //     }
            // }
            

            // Calculation
            switch (oper)
            {
                case "+":
                    Console.WriteLine(Calculator.add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(Calculator.sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Calculator.mult(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(Calculator.div(num1, num2));
                    break;        
                default:
                    Console.WriteLine("Error");
                    break;  
            }

        }
    }
}
