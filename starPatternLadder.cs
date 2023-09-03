using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program to print* .... in different rows");
        int n = 1;
        char a='1';
        Console.WriteLine("Write the number till which you want the pattern: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the symbol you want to print: ");
        a=(char)Console.Read();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
                
            }
            Console.WriteLine(a);
            
        }
        Console.ReadKey();
    }
}
