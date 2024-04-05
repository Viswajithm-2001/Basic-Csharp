using System;
namespace Datetime;
class Program{
    static double factorial(int n){
        double val = 1;
        if(n==0)
        return 1;
        for(int i=1;i<=n;i++){
            val*=(double)i;
        }
        return val;

    }
    public static void Main(string[] args)
    {
        //Create a DateTime object with values (2021,8,10,10,40,32).
        //age,dob,Age in total number of days, total hours and total minutes he lived.
                DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                DateTime date2 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                TimeSpan age = date2-date;

                Console.WriteLine("Age : "+(date2.Year-date.Year));
                Console.WriteLine("Day : "+date.DayOfWeek);
                Console.WriteLine("Number of days : "+(Math.Round(age.TotalDays)));
                Console.WriteLine("Number of hours : "+Math.Floor(age.TotalHours));
                Console.WriteLine("Number of minutes : "+Math.Floor(age.TotalMinutes));

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
int n = 8;
double val=0.0;


for(int i=0;i<=n;i++){
val+=((Math.Pow(2,i))/factorial(i));

}
Console.WriteLine(Math.Round(val,2));
//+++++++++++++++++++++++++++++++++++++=+++++++++++++++++++++++++++++++++++++++++++++++++
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
int [,]arr1=new int[row,col];
int [,] arr2=new int[col,row];
for(int i=0;i<row;i++){
    for(int j=0;j<col;j++){
        arr1[i,j]=int.Parse(Console.ReadLine());
    }
}
for(int i=0;i<row;i++){
    for(int j=0;j<col;j++){
        arr2[i,j]=int.Parse(Console.ReadLine());
    }
}
int [,] res = new int[row,row];
for(int i=0;i<row;i++){
    for(int j=0;j<row;j++){
        res[i,j]=0;
        for(int k=0;k<n;k++){
            res[i,j]+=arr1[i,k]*arr2[k,j];
        }
    }
}

        
//         Console.WriteLine("Year: "+date.Year);
//         Console.WriteLine("Month: "+date.Month);
//         Console.WriteLine("Hour: "+date.Hour);
//         Console.WriteLine("Day: "+date.Day);
//         Console.WriteLine("Minute: " +date.Minute);
//         Console.WriteLine("Seconds"+date.Second);
//         Console.WriteLine(date.ToString("yyyy/MM/dd hh:mm:ss"));



// // Split that string into years, Month, Day, Hours, Minutes and Seconds. Print it in reverse order.
//         Console.WriteLine(date.ToString("tt ss mm hh dd MM yyyy"));
// //3. Get date time object in string format (yyyy/MM/dd hh:mm:ss tt) from user and print the year, month, and day.
//         Console.WriteLine("Enter Input(If you dont you are in a loop)\n Format: yyyy/MM/dd hh:mm:ss tt");
//         bool temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime date1);
//         while(!temp){
//             Console.WriteLine("Enter valid input as in Format: yyyy/MM/dd hh:mm:ss tt");
//             temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date1);

//         }
//         Console.WriteLine(date.ToString("yyyy/MM/dd "));
        
    }
}