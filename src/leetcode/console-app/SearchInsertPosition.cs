//https://leetcode.com/problems/search-insert-position/?envType=problem-list-v2&envId=array

namespace console_app;

public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
                return mid;

            if (target < nums[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }

        return low;
    }
}