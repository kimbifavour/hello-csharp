﻿using System;
using System.Threading;
using System.Globalization;

class Run{
    public static void Main(){
        // ChapterFour.One();
        // ChapterFour.Two();
        ChapterFour.Three();
        // ChapterFour.Four();
        // ChapterFour.Five();
        // ChapterFour.Six();
        // ChapterFour.Seven();
        // ChapterFour.Eight();
        // ChapterFour.Nine();
        // ChapterFour.Ten();
        // ChapterFour.Eleven();
        // ChapterFour.Twelve(); 
    }
}


    // public class CultureInfo{
    //     public static void Culture(){
    //         DateTime d = new DateTime(2012, 02, 28, 17, 30, 19);
    //         Console.Out.WriteLine("{0:dd/MM/yy hh:mm}", d); //("{0:D hh:mm}", d);
    //         Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
    //         Console.WriteLine("{0:N}", 1234.56);
    //         Console.WriteLine("{0:D}", d); // Manually changing the default culture of the Operating System in the console application
    //         //Question: When you have an expression like Console.In.ReadLine(), does that mean both Console and In are classes? That is,
    //         //Console is a class with method In and ReadLine() and In is a class with method ReadLine()?
    //     }
    // }
    
    public class Read{
        public static void ReadMethod(){
            //Using the Read() method to print a string of characters
            int codeRead = 0;
            do
            {
            codeRead = Console.Read();
            if (codeRead != 0)
            {
            Console.Write((char)codeRead);
            }
            }
            while (codeRead != 10);
        }   
    }

        
    public class Try{
        public static void TryParse(){
            string? str = Console.ReadLine();
            int intValue;
            bool parseSuccess = Int32.TryParse(str, out intValue); //Parameters: a parsing string and a variable to store the result of successful parsing
            Console.WriteLine(parseSuccess? "The Square of the number is : " + (intValue * intValue) : "Invalid number");

    //Note: The TryParse() method simultaneously returns two values, the bool result and the parsed value. 
    //This is possible because one of the values is returned as an output parameter represented (out parameter_name)
        }
    }

    public class ReadKeyMethod{
        public static void ReadKey(){
            //Reads the key entered without waiting for the enter key. Used to determine key combinations
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character Entered: " + key.KeyChar);
            Console.WriteLine("Special Characters: " + key.Modifiers); //Enter Shift+A

            
            Console.Write("Enter person name: ");
            string? person = Console.ReadLine();
            Console.Write("Enter book name: ");
            string? book = Console.ReadLine();
            string? from = "Authors Team";
            Console.WriteLine(" Dear {0},", person);
            Console.Write("We are pleased to inform " +
            "you that \"{1}\" is the best Bulgarian book. {2}" +
            "The authors of the book wish you good luck {0}!{2}",
            person, book, Environment.NewLine);
            Console.WriteLine(" Yours,");
            Console.WriteLine(" {0}", from);

        }
    }


    public class ChapterFour{

        public static void One(){
            Console.WriteLine("Enter three numbers");
            Console.Write("First:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: " + a + b + c);
            
        }

        public static void Two(){
            Console.Write("Enter the radius r of a circle: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI*r*r;
            double perimeter = 2*Math.PI*r;
            Console.WriteLine("Area: {0:F2} \nPerimeter: {1:F2}", area, perimeter);
        }

        public static void Three(){
            Console.Write("Company Name: ");
            string? company_name = Console.ReadLine();
            Console.Write("Company Address: ");
            string? company_address = Console.ReadLine();
            Console.Write("Company Website: ");
            string? website = Console.ReadLine();
            Console.Write("Phone Number: ");
            int phone_number = Int32.Parse(Console.ReadLine());
            Console.Write("Fax Number: ");
            int fax_number = Int32.Parse(Console.ReadLine());
            Console.Write("Manager Firstname: ");
            string? manager_name = Console.ReadLine();
            Console.Write("Manager Surname: ");
            string? manager_surname = Console.ReadLine();
            Console.Write("Manager Number: ");
            int manager_number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCompany Info\nCompany Name: {0}\nCompany Address: {1}\nCompany Website: {2}\nPhone Number: {3}" + 
            "\nFax Number: {4}\r\n\nManagerInfo\n*First Name: {5}\n*Surname: {6}\n*Phone Number: {7}", 
            company_name, company_address, website, phone_number, fax_number, manager_name, manager_surname, manager_number );
        }

        public static void Four(){
            Console.Write("Enter a number to print its Hexadecimal value: ");
            int hex = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive fractional number: ");
            float positive_fraction = float.Parse(Console.ReadLine());
            Console.Write("Enter negative fractional number: ");
            float negative_fraction = float.Parse(Console.ReadLine());
            Console.WriteLine("Hex: 0X{0, -8 :X}", hex);
            Console.WriteLine("Fraction: {0, -10 :F}", positive_fraction);
            Console.WriteLine("Fraction: {0, -10 :f}", negative_fraction);
        }

        public static void Five(){
            Console.Write("Lower range: ");
            int lower_range = int.Parse(Console.ReadLine());
            Console.Write("Upper range: ");
            int upper_range = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = lower_range; i<=upper_range; i++){
                if(i%5 == 0){
                    count++;
                    Console.WriteLine("{0}", i);
                }
            }Console.WriteLine("There exist {0} numbers between {1} and {2} " + 
            "whose division by 5 yields a remainder of 0", count, lower_range, upper_range);
        }

        public static void Six(){
            Console.WriteLine("\nSix: Greater of two numbers.");
            //To find the greater of two numbers without using conditional statements or comparators.
            int num1 = 5;
            int num2 = 3;
            int greater = Math.Max(num1, num2);
            Console.WriteLine("The greater of the two numbers, {0} and {1} is {2}", num1, num2, greater);
        }

        public static void Seven(){
            Console.WriteLine("\nSeven: Sum of five integers");
            Console.WriteLine("Enter five integers: ");
            int sum = 0;
            int[] numbers = new int[5];
            for(int i = 0; i<5; i++){
                Console.Write("=>");
                numbers[i] = int.Parse(Console.ReadLine());

                // Type type = numbers[i].GetType();
                // while(type != typeof(int)){
                //     Console.WriteLine("Enter an Integer: ");
                //     Console.Write("=>");
                //     numbers[i] = int.Parse(Console.ReadLine());
                // }
                    sum = sum + numbers[i];
            }

            Console.WriteLine("Their sum is {0}", sum);
        }

        public static void Eight(){
            Console.WriteLine("\nEight: Greatest of five numbers");
            Console.WriteLine("Enter five integers: ");
            int[] numbers = new int[5];
            for(int i = 0; i<5; i++){
                Console.Write("=>");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int greater = 0;
            for(int i = 0; i<5; i++){
                greater = Math.Max(greater, numbers[i]);
            }
            Console.WriteLine("The greatest is {0}", greater);
        }

        public static void Nine(){
            Console.WriteLine("\nNine: Sum of n number of numbers");
            Console.Write("Enter the number of numbers, n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter these {0} numbers: ", n);
            int[] numbers = new int[n];
            int sum = 0;

            for(int i = 0; i<n; i++){
                Console.Write("=>");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine("Sum: {0}", sum);

        }

        public static void Ten(){
            Console.WriteLine("\nTen: Prints numbers in the range 1 to n");
            Console.Write("Enter the last number in the range: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i<=number; i++){
                Console.Write(i + ", ");
            }
        }

        public static void Eleven(){
            Console.WriteLine("\nEleven: Fibonacci Series");
            Console.WriteLine("First 50 numbers in the fibonacci series");
            long first = 0;
            long second = 1;
            Console.Write("{0}, {1}, ", first, second);
            for(int i = 0; i<48; i++){
                long next = first + second;
                Console.Write("{0}, ", next);
                first = second;
                second = next;
            }
            
        }

        public static void Twelve(){
            Console.WriteLine("\nTwelve: Sum of fractional sequence.");
            Console.Write("How many terms should be in the sequence: ");
            float n = float.Parse(Console.ReadLine());
            float sum = 1F;
            for (float i = 2; i<n+1; i++){
                sum = sum + (1/i);
            }
                Console.Write("{0 :F3}",sum);
        }
    }

