public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int num1 = n*m;
        
        int a = n;
        int b = m;
        while (b != 0) {
            int temp = a % b;
            a = b;
            b = temp;
        }
        
        // 최대공약수와 최소공배수 계산
        answer[0] = a; // 최대공약수
        answer[1] = num1 / a; // 최소공배수
        
        return answer;
        
        
        return answer;
    }
}