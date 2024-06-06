// 060624 Submission
public class Solution {
    public int Search(int[] nums, int target) {
        // Approach
        // 1) Instantiate a left, right and mid pointer, where mid = length of nums/2
        // 2) while loop (while mid is not equal to left or right)
        // 3) If mid > target, shift right pointer to mid, set mid as left+right/2
        // 4) If mid < target, shift left pointer to mid, set mid as left+right/2
        // 5) If mid == target, return mid
        // 6) Else, return -1

        int left = 0;
        int right = nums.Length -1;

        while (left <= right){
            int mid = left+ (right - left)/2;
            if (nums[mid] == target){
                return mid;
            }
            if (nums[left] == target){
                return left;
            }
            if (nums[right] == target){
                return right;
            }
            if (nums[mid] > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
        }
        return -1;

        // Runtime = 141ms, beats 53.58% of users
        // Memory = 51.39MB, beats 84.53% of users
    }
}
