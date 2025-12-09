//https://leetcode.com/problems/count-special-triplets/description

namespace console_app;

public class CountSpecialTriplets
{
    public int SpecialTriplets(int[] nums)
    {
        const int mod = 1_000_000_007;
        long result = 0;

        Dictionary<int, long> right = [];
        foreach (int num in nums)
        {
            right.TryAdd(num, 0);
            right[num]++;
        }

        Dictionary<int, long> left = [];

        foreach (int num in nums)
        {
            right[num]--;
            int need = num * 2;

            long leftCount = left.ContainsKey(need) ? left[need] : 0;
            long rightCount = right.ContainsKey(need) ? right[need] : 0;

            result = (result + leftCount * rightCount) % mod;


            left.TryAdd(num, 0);
            left[num]++;
        }

        return (int)result;
    }
}