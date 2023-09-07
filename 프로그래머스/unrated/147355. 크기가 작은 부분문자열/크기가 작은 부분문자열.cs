using System;

public class Solution {
    public int solution(string t, string p) {
        
        //Substring(int startIndex, int length)
        
        int answer = 0;
        
        for(int i  = 0 ; i < t.Length-p.Length+1;i++)
        {
          string SplitStr =  t.Substring( i, p.Length);
         long num1 = long.Parse(SplitStr);
          long num2 = long.Parse(p);
          if (num1<=num2)
          {
              answer++;
          }
              
        }
        
        return answer;
    }
}