using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the inital value: ");
        int initialvalue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the end value: ");
        int endvalue = Convert.ToInt32(Console.ReadLine());
        int result =0;
        for(int i=initialvalue;i<=endvalue;i++){
            result+=(i*i);
        }
        Console.WriteLine("Result is: "+result);

    }
}