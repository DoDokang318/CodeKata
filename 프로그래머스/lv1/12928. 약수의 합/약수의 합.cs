public class Solution {
    public int solution(int n) {
        int answer = 0;
        //for 문으로 1분 터  n 까지  나머지가 0 인 것만  더한다 
        for(int i = 1 ; i <= n ; i++ )
        {
            if(n%i==0)
            {             
                answer+=i;
            }
        }
        
        return answer;
    }
}