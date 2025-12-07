//https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/

namespace console_app;

public sealed class CountOddNumbers
{
    public int CountOdds(int low, int high)
    {
        int result = 0;
        if (low % 2 == 1)
        {
            low++;
            result++;
        }

        if (high % 2 == 1)
        {
            high--;
            result++;
        }

        result += (high - low) / 2;
        return result;
    }
}