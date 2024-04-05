using System;
using System.Diagnostics;

namespace  TypeConversion;
class Program{
    public static void Main(string[] args)
     {
    //     Console.Write("Enter your name: ");
    //     string name = Console.ReadLine();
    //     Console.Write("Enter age: ");
    //     short age = Convert.ToInt16(Console.ReadLine());
    //     Console.Write("Enter mark of subject1: ");
    //     float sub1 = Convert.ToSingle(Console.ReadLine());
    //     Console.Write("Enter mark of subject2: ");
    //     float sub2 = Convert.ToSingle(Console.ReadLine());
    //     Console.Write("Enter mark of subject3: ");
        // float sub3 = Convert.ToSingle(Console.ReadLine());
        // Console.Write("Enter Grade: ");
        // char grade = Convert.ToChar(Console.ReadLine());
        // Console.Write("Enter mobile number: ");
        // long mob = Convert.ToInt64(Console.ReadLine());
        // Console.Write("Enter Mail id: ");
        // string mailId = Console.ReadLine();
        // float tot = sub1+sub2+sub3;
        // Console.WriteLine();
        // Console.WriteLine("Trainee Details Are: ");
        // Console.WriteLine("Name: "+name+"\n"+"Age: "+age+"\n"+"Mobile: "+mob);
        // Console.WriteLine($"Marks1: {sub1}\nMarks2: {sub2}\nMarks3: {sub3}");
        // Console.WriteLine("Total: "+tot+"\n"+$"Average: {(tot/3).ToString("0.00")}");
        // Console.WriteLine("Grade: "+ grade);
        // Console.WriteLine("Mail id: "+mailId);

        double sal = double.Parse(Console.ReadLine());
                double da = sal*0.1;
                double hra = sal*0.1;
                double tax = (sal + da + hra)*0.05;

                double res = sal + da + hra -tax;
                Console.WriteLine(res*12);


    }
}