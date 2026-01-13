namespace console_app;

public sealed class HappyNumber
{
    public bool IsHappy(int n)
        => IsHappyRecursive(n, new());

    private bool IsHappyRecursive(int n, HashSet<int> seen)
    {
        if (n == 1 || n==7)
            return true;

        if (!seen.Add(n))
            return false;

        int next = SumOfSquares(n);

        return IsHappyRecursive(next, seen);
    }

    private int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;

            n /= 10;
        }

        return sum;
    }
}