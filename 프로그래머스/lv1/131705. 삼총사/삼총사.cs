using System;

public class Solution {
    public int solution(int[] number) {
        int result = 0;    
        int Num1 = 0 ;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i+1; j < number.Length; j++)
                {
                   for(int k = j+1;k < number.Length; k++ )
                   {
                       Num1 = number[i]+number[j]+number[k];
                           if(Num1 == 0)
                           {
                               result++;
                           }
                   }
                }
                
            }
        return result;
        
        // number[i] number[i+1] 고정하고 j만++ 
    }
}