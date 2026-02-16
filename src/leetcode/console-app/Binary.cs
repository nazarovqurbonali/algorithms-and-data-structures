//https://leetcode.com/problems/add-binary/?envType=problem-list-v2&envId=math                                                                                                                                                                             
//https://leetcode.com/problems/binary-search/description/
//https://leetcode.com/problems/reverse-bits/?envType=daily-question&envId=2026-02-16

using System.Text;

namespace console_app;

public sealed class Binary
{
    public string AddBinary(string a, string b)
    {
        string result = "";
        int carry = 0;

        int i = a.Length - 1;
        int j = b.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            result = sum % 2 + result;
            carry = sum / 2;
        }

        return result;
    }


    public int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    public int ReverseBits(int n)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= n & 1;
            n >>= 1;
        }

        return result;
    }

}