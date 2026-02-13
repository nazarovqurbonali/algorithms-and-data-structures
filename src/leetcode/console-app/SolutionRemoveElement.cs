//https://leetcode.com/problems/remove-element/?envType=problem-list-v2&envId=array
namespace console_app;

public class SolutionRemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {

        int write = 0;

        for (int read = 0; read < nums.Length; read++)
        {
            if (nums[read] != val)
            {
                nums[write] = nums[read];
                write++;
            }
        }
        return write;
    }
}