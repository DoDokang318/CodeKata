using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;       
      string strnum = n.ToString();
    char[] myChar = strnum.ToCharArray();
        
        for(int i = 0 ; i < myChar.Length; i++)
        {
            int num = int.Parse(myChar[i].ToString());
            answer+=num;
        }
        
        
        
        
        return answer;
    }
}