using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);//세로
        int b = Int32.Parse(s[1]);//가로
        
        for(int i = 0;  i < b ; i++)
        {
            for(int j = 1; j <a; j++ )
            {
                 Console.Write('*');
            }
        Console.WriteLine('*');
        }
      
    }
}