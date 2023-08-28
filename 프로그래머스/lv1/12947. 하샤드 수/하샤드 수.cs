public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        string strnum = x.ToString();
        char[] Charnum = strnum.ToCharArray();
        int a = 0 ;
        for(int i = 0 ; i <Charnum.Length ; i++)            
        {
            a += int.Parse(Charnum[i].ToString());
        }
        
     if(x%a == 0 )
     {
         answer = true;
     }
        else
        {
             answer =  false ;
        }
        
        
        return answer;
    }
}