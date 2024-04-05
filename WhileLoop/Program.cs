using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        while (i <= 25)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.Write("Enter input: ");
        string number = Console.ReadLine();
        bool flag = false;
        int result;
        while (!flag)
        {
            bool nextflag = int.TryParse(number, out result);
            flag = nextflag;
            if (!nextflag)
            {
                Console.Write("Enter valid input: ");
                number = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("valid hasbeen given");
                break;
            }
        }
    }
}