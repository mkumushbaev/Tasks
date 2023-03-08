using System;

public class Reverse
{
   private static void Main()
   {
      string[] numbers = Console.In.ReadToEnd().Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

      for(int i = numbers.Length-1; i >= 0; i--)
      {
         double result = Math.Sqrt(double.Parse(numbers[i]));
         Console.WriteLine($"{result:F4}");
      }
   }
}