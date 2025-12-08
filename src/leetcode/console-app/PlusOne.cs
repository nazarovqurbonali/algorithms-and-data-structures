//https://leetcode.com/problems/plus-one/description/

namespace console_app;

public sealed class PlusOneDigit
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i]++;
            if (digits[i] < 10)
                return digits;
            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}