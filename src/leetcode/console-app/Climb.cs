//https://leetcode.com/problems/climbing-stairs/description

namespace console_app;

public sealed class Climb
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return n;
        if (n == 2)
            return n;

        int prev2 = 1;
        int prev1 = 2;
        int current = 0;

        for (int i = 3; i <= n; i++)
        {
            current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }

        return current;
    }
}