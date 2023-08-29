using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        for(int i = 0 ; i<absolutes.Length;i++)
        {
            if(!signs[i])
            {
                absolutes[i] =absolutes[i] - (absolutes[i]*2);
            }
            
            answer +=absolutes[i];
        }
        
        return answer;
    }
}