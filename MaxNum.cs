using System;
using System.Linq;

namespace MaxNum
{
  class Program
  {
    static int solve(int[] arr) {
        return arr.Max();
    }
    
    static void Main(string[] args)
    {
      Console.WriteLine(solve(new int[]{1,5,3,7,2}));    
    }
  }
}