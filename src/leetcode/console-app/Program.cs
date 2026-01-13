using System.Text;
using System.Text.Json;
using console_app;

Console.WriteLine("Starting test...");

#region RomanToInteger

//https://leetcode.com/problems/roman-to-integer/description/

/*
string input = Console.ReadLine()!;
RomanToInteger obj = new();
int result = obj.RomanToInt(input);
Console.WriteLine("Result: " + result);
*/

#endregion

#region CountOddNumbers

//https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/
/*
int low = int.Parse(Console.ReadLine()!);
int high = int.Parse(Console.ReadLine()!);

CountOddNumbers obj = new();
int result = obj.CountOdds(low, high);
Console.WriteLine("Result: " + result);
*/

#endregion

#region CountTriple

//https://leetcode.com/problems/count-square-sum-triples/description/

/*
int input = int.Parse(Console.ReadLine()!);
CountTriple obj = new();
int result = obj.CountTriples(input);
Console.WriteLine("Result: " + result);
*/

#endregion

#region PlusOneDigit

//https://leetcode.com/problems/plus-one/description/

/*
int[] input = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
PlusOneDigit obj = new();
int[] result = obj.PlusOne(input);
Console.Write("[ ");
foreach (int r in result)
{
    Console.Write(r + " ");
}

Console.Write(" ]");
*/

#endregion

#region CountSpecialTriplets

//https://leetcode.com/problems/count-special-triplets/description
/*
int[] input = [6, 3, 6];
CountSpecialTriplets obj = new();
int result = obj.SpecialTriplets(input);

Console.WriteLine("Result: " + result);
*/

#endregion

#region SplitWithMinNum

//https://leetcode.com/problems/split-with-minimum-sum/description/

/*
int num = 4234;
SplitWithMinNum obj = new();
int result = obj.SplitNum(num);
Console.WriteLine("Result: " + result);
*/

#endregion

#region Binary

//https://leetcode.com/problems/add-binary/?envType=problem-list-v2&envId=math                                                                                                                                                                             

/*
string a = "11";
string b = "1";
Binary obj = new();
string result = obj.AddBinary(a,b);
Console.WriteLine("Result: " + result);
*/


//https://leetcode.com/problems/binary-search/description/

/*
int[] arr = [84, 455, 74, 2, 555, 6, 888, 2, 3, 787, 58, 99];
int target = 58;
Array.Sort(arr);

Binary obj = new();
int result = obj.BinarySearch(arr, target);
Console.WriteLine("Result: " + result);
*/

#endregion

#region Sqrt

//https://leetcode.com/problems/sqrtx/description/

/*
Sqrt obj = new();
int result = obj.MySqrt(81);
Console.WriteLine("Result: " + result);
*/

#endregion

#region Climb

//https://leetcode.com/problems/climbing-stairs/description

/*
Climb obj = new();
int result = obj.ClimbStairs(45);
Console.WriteLine("Result: " + result);
*/

#endregion