// Problem: 88. Merge Sorted Array
// Link: https://leetcode.com/problems/merge-sorted-array/description/
// Difficulty: Easy

using System;

namespace Solutions;

public class Solution0088
{
    public void Merge1(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }

        Array.Sort(nums1);
    }

    public void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        int mPointer = m - 1;
        int nPointer = n - 1;
        int mnPointer = m + n - 1;

        while (mPointer >= 0 && nPointer >= 0)
        {
            if (nums1[mPointer] > nums2[nPointer])
            {
                nums1[mnPointer] = nums1[mPointer];
                mPointer--;
            }
            else
            {
                nums1[mnPointer] = nums2[nPointer];
                nPointer--;
            }

            mnPointer--;
        }

        // When nums1 runs out of numbers before nums2
        while (nPointer >= 0)
        {
            nums1[mnPointer] = nums2[nPointer];
            nPointer--;
            mnPointer--;
        }
    }
}
