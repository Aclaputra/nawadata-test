using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostLetter
{
  class Program
  {
    static string solve(string input) {
      Dictionary<string, int> result = new Dictionary<string, int>();

      foreach (char s in input) {
        string letter = char.ToString(s);
        if (result.ContainsKey(letter)) {
          result[letter] = result[letter] + 1;
          continue;
        }
        result.Add(letter, 1);
      }

      return result.FirstOrDefault(x => x.Value == result.Values.Max()).Key;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(solve("hello"));    
      Console.WriteLine(solve("microsoft"));
    }
  }
}