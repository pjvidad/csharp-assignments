using System;

class TwoSumProgram
{
    //logic
    static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return null; // no solution found
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int numElements = int.Parse(Console.ReadLine());

        if (numElements < 2)
        {
            Console.WriteLine("At least two elements are required.");
            return;
        }

        int[] nums = new int[numElements];

        Console.WriteLine($"Enter the {numElements} elements one by one:");

        for (int i = 0; i < numElements; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the target:");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSum(nums, target);

        Console.WriteLine($"Input: nums = [{string.Join(", ", nums)}], target = {target}");

        if (result != null)
        {
            Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No two sum solution");
        }
    }
}