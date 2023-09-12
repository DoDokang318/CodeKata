using System;
public class Solution {
    public string solution(string s, int n) {
            string answer = "";
        
            char[] StrArr = s.ToCharArray();

            for(int i = 0; i < StrArr.Length; ++i)
            {
             
                if (StrArr[i] == ' ') 
                {
                    continue;
                }
             
                int StrNum = Convert.ToInt32(StrArr[i]) + n;
            if((StrArr[i] >= 'A' && StrArr[i] <= 'Z'))
            {
                if(StrNum > 'Z')
                {
                    StrNum-=26;
                }
            }   
            else if(StrNum > 'z')
            {
            StrNum-=26;
            }
                    
                    
                StrArr[i] = Convert.ToChar(StrNum);
                
            }
        
         answer = new string(StrArr);
        return answer;
    }
}