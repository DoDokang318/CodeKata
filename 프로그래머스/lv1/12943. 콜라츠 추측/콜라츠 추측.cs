public class Solution {
    public int solution(long num) {
        int answer = 0;
        int a = -1;
int count = 0;
                  
               for( count = 0 ; count<=500&& num != 1 ; count++ )
                  {
                   if(num%2==0)
                    {
                     num = num/2;   
                    
                    }
                   else
                   {
                      num = num*3+1;    
                     
                   }
                                      
                  }
                if(num == 1)
                           {
                               return count;
                           }
                           else
                           {
                           return a;
                           }
                
            }            
                            
        
    }
