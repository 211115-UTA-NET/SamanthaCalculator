namespace HelloWorld
{
    using System;
    using System.ComponentModel;
    using System.Collections;
    
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to my Virtual Calculator!");
            double userSelection;
            double x;
            double y;
            do { 
                Console.WriteLine("\n***********\nPlease select a menu option.\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit the Calculator");

            userSelection = Convert.ToDouble(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("You have selected Addition.\nPlease Enter the first number.");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter the second number.");
                    y = Convert.ToDouble(Console.ReadLine());
                    double result = x+y;
                    Console.WriteLine("\n" + x + " + " + y + " = "+ result);
                    Console.WriteLine($"The answer is " + result + "!");
                    break;
                case 2:
                Console.WriteLine("You have selected Subtraction.\nPlease Enter the first number.");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter the second number.");
                    y = Convert.ToDouble(Console.ReadLine());
                    result = x-y;
                    Console.WriteLine("\n" + x + " - " + y + " = "+ result);
                    Console.WriteLine($"The answer is " + result + "!");
                    break;
                case 3:
                    Console.WriteLine("You have selected Multiplication.\nPlease Enter the first number.");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter the second number.");
                    y = Convert.ToDouble(Console.ReadLine());
                    result = x*y;
                    Console.WriteLine("\n" + x + " * " + y + " = "+ result);
                    Console.WriteLine($"The answer is " + result + "!");
                    break;
                case 4:
                    Console.WriteLine("You have selected Division.\nPlease Enter the first number.");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter the second number.");
                    y = Convert.ToDouble(Console.ReadLine());
                    if(y == 0){
                        Console.WriteLine("Cannot divide by zero!\nPlease enter a second number");
                        y = Convert.ToDouble(Console.ReadLine());
                    }
                    result = x/y;
                    Console.WriteLine("\n" + x + " / " + y + " = "+ result);
                    Console.WriteLine($"The answer is " + result + "!");
                    break;
                default:
                    Console.WriteLine("\n" + userSelection + " is not a menu option.");
                    break;
            }
            }while (userSelection != 5);
            if(userSelection == 5){
                Console.WriteLine("You have chosen to exit the calculator. Have a great day!");
            }
            
            }

            
        }

}    
