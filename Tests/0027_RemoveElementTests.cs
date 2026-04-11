using System.Globalization;
using Solutions;

namespace Tests;

public class Solution0027Tests
{
    public static TheoryData<int[], int, int, int[]> GetTestData()
    {
        var data = new TheoryData<int[], int, int, int[]>
        {
            // LeetCode Example 1
            {[3, 2, 2, 3], 3, 2, [2, 2]},

            // LeetCode Example 2 with expected array pre-sorted
            {[0,1,2,2,3,0,4,2], 2, 5, [0,0,1,3,4]}
        };

        return data;
    }

    private void RunTestEngine(int[] nums, int val, int expectedK, int[] expectedArray, Func<int[], int, int> methodTested)
    {
        int resultK = methodTested(nums, val);

        Assert.Equal(expectedK, resultK);

        Array.Sort(nums, 0, resultK);
        
        for (int i = 0; i < resultK; i++)
        {
            Assert.Equal(expectedArray[i], nums[i]);
        }
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void RemoveElement1_ValidInputs_MatchesExpectedKAndExpectedArray(int[] nums, int val, int expectedK, int[] expectedArray)
    {
        var solution = new Solution0027();

        RunTestEngine(nums, val, expectedK, expectedArray, solution.RemoveElement1);
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void RemoveElement2_ValidInput_MatchesExpectedKAndExpectedArray(int[] nums, int val, int expectedK, int[] expectedArray)
    {
        var solution = new Solution0027();

        RunTestEngine(nums, val, expectedK, expectedArray, solution.RemoveElement2);
    }
}