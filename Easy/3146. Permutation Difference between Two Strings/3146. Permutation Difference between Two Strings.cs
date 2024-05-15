// 150524 Submission
public class Solution {
    public int FindPermutationDifference(string s, string t) {
        // Approach
        // 1) Instantiate a int variable to return as answer
        // 2) For loop both strings to get the abs difference and add to the answer
        // 3) Return answer
        
        int answer = 0;
        for (int i = 0; i < s.Length; i ++){
            answer += Math.Abs(s.IndexOf(s[i]) - t.IndexOf(s[i]));
        }
        return answer;
        
        // Runtime = 40ms, beats 90.53% of users
        // Memory = 41.47MB, beats 76.26% of users
    }
}
