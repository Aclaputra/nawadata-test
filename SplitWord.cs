using System;

namespace SplitWord
{
  class Program
  {
    static int solve(string input) {
      return input.Split(
        new string[]{" ", ", "}, 
        System.StringSplitOptions.RemoveEmptyEntries).Length;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(solve("Halo, nama saya John Doe"));    
    }
  }
}