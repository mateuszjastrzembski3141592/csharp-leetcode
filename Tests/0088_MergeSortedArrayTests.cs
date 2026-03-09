using System;
using Xunit;
using Solutions;

namespace Tests;

public class Solution0088Tests
{
    public static TheoryData<int[], int, int[], int, int[]> GetTestData()
    {
        var data = new TheoryData<int[], int, int[], int, int[]>
        {
            // LeetCode Example 1
            { [1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3, [1, 2, 2, 3, 5, 6] },

            // LeetCode Example 2
            { [1], 1, [], 0, [1] },

            // LeetCode Example 3
            { [0], 0, [1], 1, [1] }
        };

        return data;
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Merge1_ValidInputs_MatchesExpectedArray(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        var solution = new Solution0088();
        solution.Merge1(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Merge2_ValidInputs_MatchesExpectedArray(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        var solution = new Solution0088();
        solution.Merge2(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }
}
