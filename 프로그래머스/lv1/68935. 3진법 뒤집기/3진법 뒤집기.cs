using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> myList = new List<int>();
        while (n > 0)
        {
         int a = n / 3; 
         int b = n % 3; 
         myList.Add(b);  // 00
         n = a; 
        }
        
        myList.Reverse();
       for(int i = 0 ; i < myList.Count; i++)    
       {
            answer += myList[i] * (int)Math.Pow(3, i);
       }
        return answer;
    }
}
              
//10진법 ->3진법 -> 리버스-> 10진법으로 변환 

