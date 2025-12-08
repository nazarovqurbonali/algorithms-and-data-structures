//https://leetcode.com/problems/count-square-sum-triples/description/
namespace console_app;

public class CountTriple
{
    public int CountTriples(int n)
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                double sqrt = Math.Sqrt(i * i + j * j);
                if (sqrt - (int)sqrt == 0 && sqrt <= n)
                    count += 2;
            }
        }

        return count;
    }
}