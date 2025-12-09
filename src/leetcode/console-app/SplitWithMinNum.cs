//https://leetcode.com/problems/split-with-minimum-sum/description/

namespace console_app;

public class SplitWithMinNum
{
    public int SplitNum(int num)
    {
        int length = num.ToString().Length;
        int[] nums = new int[length];

        for (int i = length - 1; i >= 0; i--)
        {
            nums[i] = num % 10;
            num /= 10;
        }

        Array.Sort(nums);

        int num1 = 0;
        int num2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0) 
            {
                num1 = num1 * 10 + nums[i];
            }
            else 
            {
                num2 = num2 * 10 + nums[i];
            }
        }

        return num1 + num2;
    }
}