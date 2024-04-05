using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        Dat
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        Console.Write("Enter the substring: ");
        string substr = Console.ReadLine();
        int n = substr.Length;
        int count=0;
        for(int i=0;i<str.Length-n+1;i++){
            string search = str.Substring(i,n);
            if(search.Equals(substr)){
                count+=1;
            }
        }
        Console.WriteLine("No of counts is "+count);
        
    }
}