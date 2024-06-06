// 060624 Submission
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Approach
        // 1) Create a dictionary to store the sorted string as the key and the original string as the value
        // 2) Loop through all keys and store each value in the list and return as answer

        Dictionary<string,List<String>> dict = new Dictionary<string,List<String>>();
        foreach (String s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            if (!dict.ContainsKey(sortedString)) {
                dict[sortedString] = new List<string>();
            }
            dict[sortedString].Add(s);
        }
        return new List<IList<string>>(dict.Values);

        // Runtime = 117ms, beats 100% of users
        // Memory = 78.98MB, beats 86.12% of users
    }
}
