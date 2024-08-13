// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;


/*
 Exemplo 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 */

int[] TwoSum(int[] nums, int target){
    // { 2, 7, 11, 15 };

    for (int i = 0; i < nums.Length; i++)
    { 
        for (int j = 1; j < nums.Length; j++)
        {

            if(i == j) continue;

            int calc = nums[i] + nums[j];

            if (calc == target) return new int[] { i, j };
        }
    }
    return new int[0];
}

int[] rsult = TwoSum(new int[] { 2, 5, 5, 11 }, 10);
Console.WriteLine($"Resultdos {rsult[0]}, e {rsult[1]}");