using System;

public class Solution {
    public int[] solution(string s) {
        char[] c = s.ToCharArray();
        int[] answer = new int[c.Length];
        answer[0] = -1;
        for(int i = 0 ; i < c.Length; i++)
        {
            for(int j = i-1 ;j>=0;j-- )
            {
                if(c[i] == c[j])
                {
                 answer[i] = i-j;                   
                 break;   
                }               
               
            }
        }
        for(int i = 0; i <answer.Length;i++ )
        {
            if(answer[i] == 0)
            {
                answer[i] = -1;
            }
        }
        
        
        return answer;
    }
}