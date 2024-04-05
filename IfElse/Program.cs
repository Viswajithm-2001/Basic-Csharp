using System;

namespace IfElse;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        if(mark<=100 && mark>=0){
            if(mark>80){
            Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark <=80){
            Console.WriteLine("Grade B");
        }
        else if(mark >35 && mark<=60){
            Console.WriteLine("Grade C");
        }
        else if(mark<36){
            Console.WriteLine("Grade D");
        }
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}