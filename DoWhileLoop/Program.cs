using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {

        
        
        string option = "";
        do
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0){
                Console.WriteLine("number is even");
            }
            else{
                Console.WriteLine("Number is odd");
            }
            Console.Write("Want to do it again? (yes/no): ");
            option=Console.ReadLine();
            
            while(!(option=="yes"||option=="no")){
                Console.WriteLine("Provide the valid answer (yes/no): ");
                option=Console.ReadLine();
            }

        }while(option=="yes");
    }
}