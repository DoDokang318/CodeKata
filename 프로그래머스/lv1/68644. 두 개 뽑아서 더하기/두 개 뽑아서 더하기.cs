using System;
using System.Collections.Generic;
   public class Solution {
    public int[] solution(int[] numbers) {
       
        List<int> answer = new List<int>();
        int a = 0;
        
        for(int i = 0; i < numbers.Length ; i++)
        {
           
            for(int j = i+1; j < numbers.Length; j++ )
            {
              a = numbers[i]+numbers[j] ;                   
              if(!answer.Contains(a))
              {
                  answer.Add(a);
              }
                                          
            }
        }
        
        answer.Sort();
        return answer.ToArray();
    }
}