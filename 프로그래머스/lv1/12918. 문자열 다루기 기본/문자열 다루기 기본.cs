public class Solution {
    public bool solution(string s)
    {
          int result;
          
        
         
          if (int.TryParse(s, out result))
          {
              if(s.Length==4||s.Length==6)
              {                                  
                 return true;                
              }
              else
              {
                 return false;
              }
             
          }
         else
              {
                 return false;
              }
    
    }
}