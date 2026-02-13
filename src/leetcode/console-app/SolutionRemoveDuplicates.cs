//https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=problem-list-v2&envId=array

namespace console_app;

public class SolutionRemoveDuplicates
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        //first element always is unique
        int emptyHomeForUniqueOrder = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[emptyHomeForUniqueOrder - 1])
            {
                nums[emptyHomeForUniqueOrder]=nums[i];
                emptyHomeForUniqueOrder++;
            }
        }
        return  emptyHomeForUniqueOrder;
    }
}