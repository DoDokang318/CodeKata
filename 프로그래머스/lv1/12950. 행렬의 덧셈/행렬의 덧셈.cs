public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int num1 = arr1.GetLength(0);   
        int  num2 = arr1.GetLength(1);

        int[,] answer = new int[num1,num2]; // 결과를 저장할 배열 생성
        
        for (int i = 0; i < num1; i++) {
            for (int j = 0; j < num2; j++) {
                answer[i, j] = arr1[i, j] + arr2[i, j]; 
            }
        }

        return answer;
    }
}