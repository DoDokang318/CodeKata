public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        int count = 0 ;
         char[] a = s.ToCharArray();
      
        for (int i = 0 ;i < s.Length; i++) 
        {
            if(a[i]==' ')
              {
                   count = 0;
                 answer +=' ';
              }
            
           else if(count%2==0)
            {
                 answer += char.ToUpper(a[i]);
                count++;
            }
            else if(count%2==1)
            {
                answer +=char.ToLower(a[i]);
                count++;
            }
            
           
        }  
        return answer;
    }
}