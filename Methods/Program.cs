using System;
namespace Methods;
class Program
{
    static double Addition(double a, double b)
    {
        return a + b;
    }
    static double Subtraction(double a, double b)
    {
        return a + b;
    }
    static double Multiplication(double a, double b)
    {
        return a + b;
    }
    static double Division(double a, double b)
    {
        return a + b;
    }

    public static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter '+' for addition \nEnter '-' for subtraction\nEnter '*' for multiplication\nEnter '/' for division");
            Console.Write("Enter your choice: ");
            char a = Convert.ToChar(Console.ReadLine());
            while (!(a == '+' || a == '-' || a == '*' || a == '/'))
            {
                Console.WriteLine("Enter valid symbol: ");
                a = Convert.ToChar(Console.ReadLine());
            }
            switch (a)
            {
                case '+':
                    {
                        Console.WriteLine("Answer is : " + Addition(num1, num2));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Answer is : " + Subtraction(num1, num2));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("Answer is : " + Multiplication(num1, num2));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("Answer is : " + Division(num1, num2));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        break;
                    }
            }
            Console.Write("Want to continue(yes/no):");
            choice = Console.ReadLine();
            while (!(choice == "yes" || choice == "no"))
            {
                Console.WriteLine("Please enter yes or no");
                choice = Console.ReadLine();
            }
        } while (choice == "yes");
    }
}