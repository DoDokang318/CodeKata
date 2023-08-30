using System;

public class Solution {
    public int solution(int[] numbers) {
       int[] ten = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int answer = 0;
        for(int i =0; i< ten.Length;i++)
        {
            for (int j = 0; j<numbers.Length;j++)
            {
                if (ten[i] == numbers[j])
                {
                    ten[i]=0;
                }
            }
        }
        
         for(int i =0; i< ten.Length;i++)
        {
             answer+=ten[i];
        }
        
        
        
        
        
        
        return answer;
    }
}