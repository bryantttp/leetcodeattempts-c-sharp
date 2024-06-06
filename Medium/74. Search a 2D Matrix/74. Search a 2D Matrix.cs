// 060624 Submission

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // Approach
        // 1) Loop through matrix and do Binary Search for each iteration

        foreach (int[] list in matrix){
            int left = 0;
            int right = list.Length -1;
            int mid = left + (right-left)/2;
            if (list[right] < target) {
                continue;
            }
            while (left <= right){
                if (list[mid] == target){
                    return true;
                }
                if (list[left] == target){
                    return true;
                }
                if (list[right] == target){
                    return true;
                } 
                else if (list[mid] > target){
                    right = mid - 1;
                    mid = left + (right-left)/2;
                }
                else{
                    left = mid + 1;
                    mid = left + (right-left)/2;
                }
            }
        }
        return false;

        // Runtime = 71ms, beats 79.33% of users
        // Memory = 42.95MB, beats 90.37% of users
    }
}
