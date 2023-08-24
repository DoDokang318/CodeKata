using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        char[] charArray  = cipher.ToCharArray();
        
        for(int i =code ; i<charArray.Length+1; i += code)
        {
            answer += charArray [i-1];                      
        }                     
        return answer;
    }
}