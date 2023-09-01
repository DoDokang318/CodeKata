using System;

class Solution
{
    public long solution(int price,long money, int count)
    {
        long Total =0;
       long answer = 0;
        for (int i = 1 ; i <= count ; i++)
        {
            Total += price*i;
        }
        if(money > Total )
        {
            return 0;
        }
        else
        {
          
            answer = Total - money;
            return  answer;
            
        }
        
       
    }
}