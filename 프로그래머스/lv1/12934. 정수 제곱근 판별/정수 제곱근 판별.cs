
using System;

public class Solution {
    public long solution(long n) {
       
      
       long x = (long)Math.Sqrt(n);
        
        if(n%x !=0)
        {
            return -1;
        }
        
        long answer = (x+1)*(x+1);
        
        return answer;
    }
}