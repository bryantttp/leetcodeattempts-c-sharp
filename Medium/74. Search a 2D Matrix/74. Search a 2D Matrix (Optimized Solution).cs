// 060624 Submission
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // Approach
        // 1) Do binary search to search for the array that the target is in
        // 2) Do binary search to search for target within that array

        int leftMostArray = 0;
        int rightMostArray = matrix.GetLength(0) - 1;
        int midArray = leftMostArray + (rightMostArray - leftMostArray)/2;
        while (leftMostArray <= rightMostArray){
            midArray = leftMostArray + (rightMostArray - leftMostArray)/2;
            int midLeft = matrix[midArray][0];
            int midRight = matrix[midArray][matrix[midArray].Length - 1];
            if (midLeft > target) {
                rightMostArray -= 1;
            }
            else if (midRight < target){
                leftMostArray += 1;
            }
            else{
                break;
            }
        }
        int left = 0;
        int right = matrix[midArray].Length - 1;
        while(left <= right){
            int mid = left + (right-left)/2;
            if (matrix[midArray][mid] == target){
                return true;
            }
            if (matrix[midArray][left] == target){
                return true;
            }
            if (matrix[midArray][right] == target){
                return true;
            } 
            else if (matrix[midArray][mid] > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
        }
        return false;

        // Runtime = 72ms, beats 74.78% of users
        // Memory = 43.18MB, beats 70.05% of users
        // O(log(mn)) solution
    }
}
