// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Program to print no of days in a month and Leap Year or not.");
        int i=0;
        int y=0;
        Console.WriteLine("Enter the year: ");
        y=Convert.ToInt32(Console.ReadLine());
       
        if (y%4==0){
            Console.WriteLine("This is a Leap Year\n");
        }
        else{
            Console.WriteLine("This is Not a Leap Year\n");
           
        }
        Console.WriteLine("Enter the month as number; January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12 \n: ");
        i=Convert.ToInt32(Console.ReadLine());
        switch(i){
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("No of days: 31");
            break;
            case 2:
            if (y%4==0){
            
                Console.WriteLine("No of days: 29");}
            else{
                Console.WriteLine("No of days: 28");}
            
            break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("No of days: 30");
            break;
            default:
            Console.WriteLine("Invalid Input");
            break;
        }
        Console.ReadKey();
    }
}
