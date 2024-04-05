using System;

namespace SwitchCase;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int number1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int number2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter + for addition, - for subtraction, * for multiplication, / for division");
        char a = Convert.ToChar(Console.ReadLine());
        switch(a)
        {
            case '+':
            {
                Console.WriteLine("Answer is : "+ (number1+number2));
                break;
            }
            case '-':
            {
                Console.WriteLine("Answer is : "+ (number1-number2));
                break;
            }
            case '*':
            {
                Console.WriteLine("Answer is : "+ (number1*number2));
                break;
            }
            case '/':
            {
                Console.WriteLine("Answer is : "+ (number1/number2));
                break;
            }
            case '%':
            {
                Console.WriteLine("Answer is : "+(number1%number2));
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Operation");
                break;
            }
        }
    }
}