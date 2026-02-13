//https://leetcode.com/problems/longest-common-prefix/description/?envType=problem-list-v2&envId=array
namespace console_app;

public class LongestCommonPref
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        if (strs.Length == 1)
            return strs[0];

        string first = strs[0];

        for (int i = 0; i < first.Length; i++)
        {
            char c = first[i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != c)
                    return first.Substring(0, i);
            }
        }

        return first;
    }
}