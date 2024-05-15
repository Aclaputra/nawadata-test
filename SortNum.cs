using System;

namespace SortNum
{
  class Program
  {
    static int[] solve(int[] nums) {
      Array.Sort(nums);
      return nums;
    }
    static void Main(string[] args)
    {
      foreach(var item in solve(new int[]{3,1,5,2,4})) {
        Console.WriteLine(item);    
      }
    }
  }
}