//https://leetcode.com/problems/add-digits/description
//https://leetcode.com/problems/ugly-number/description
//https://leetcode.com/problems/missing-number

namespace console_app;

public sealed class Digit
{
    public int AddDigits(int num)
    {
        while (num >= 10)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            num = sum;
        }

        return num;
    }

    public bool IsUgly(int n)
    {
        if (n <= 0)
            return false;

        int[] digits = [2, 3, 5];
        foreach (int digit in digits)
        {
            while (n % digit == 0)
                n /= digit;
        }

        return n == 1;
    }

    public int MissingNumber(int[] nums)
    {
        int num = nums.Length;
        int total = num * (num + 1) / 2;
        int sum = 0;
        foreach (int n in nums)
            sum += n;
        return total - sum;
    }
}