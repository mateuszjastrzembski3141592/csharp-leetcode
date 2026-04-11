// Problem: 27. Remove Element
// Link: https://leetcode.com/problems/remove-element/description/
// Difficulty: Easy
// Tags: Array, Two Pointers

namespace Solutions;

public class Solution0027
{
    public int RemoveElement1(int[] nums, int val)
    {
        int pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[pointer] = nums[i];
                pointer++;
            }
        }

        return pointer;
    }

    public int RemoveElement2(int[] nums, int val)
    {
        int start = 0;
        int end = nums.Length;

        while (start < end)
        {
            if (nums[start] != val)
            {
                start++;
            }
            else
            {
                nums[start] = nums[end - 1];
                end--;
            }
        }

        return end;
    }
}