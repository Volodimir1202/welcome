// 9.Даний масив розміру N. Здійснити циклічний зсув елементів масиву
// ліворуч (праворуч) на одну позицію.
using System;

namespace Rextester
{
  public class Program
  {
      public static void Main (string[]args)
    {
        int n;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        
        Random random = new Random();
        for(int i = 0; i < a.Length; i++){
            a[i] = random.Next(0, 100);
            Console.Write(a[i]+",");
        }
        
        for(int i = 1; i < a.Length; i++){
            int b = a[i];
            a[i] = a[i-1];
            a[i-1] = b;
        }
        
        Console.WriteLine();
        for(int i = 0; i < a.Length; i++)
            Console.Write(a[i]+",");
    }
  }
}