using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result);
    }

    static bool ContainsDuplicate(int[] nums)
    {
        List<int> set = new List<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }

        return false;
    }
}