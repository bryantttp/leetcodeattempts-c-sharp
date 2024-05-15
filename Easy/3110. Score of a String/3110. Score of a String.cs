// 150424 Submission
public class Solution {
    public int ScoreOfString(string s) {
        int score = 0;
        for(int i = 0; i < s.Length-1; i++){
            score += Math.Abs(s[i] - s[i+1]);
        }
        return score;
        // Runtime = 37ms, beats 94.41% of users
        // Memory = 38.87MB, beats 58% of users
    }
}
