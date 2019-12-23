// 9.Створити ліст інтових значень, який може вміщати тільки 2 та 1, вивести
// серії повторень, для кожного чисел. Видалити елементи з простими
// індексами.

using System;
using System.Collections.Generic;

namespace Rextester
{
  public class Program
  {
      public static void Main (string[]args)
    {
        List<int> l = new List<int>();
        Console.WriteLine("Adding elements in list");
        int j = 1;
        int value = 0;
        Console.WriteLine("value == 0 - stop Adding");
        do{
            Console.WriteLine("element "+j);
            value = Convert.ToInt32(Console.ReadLine());
            if (value>2 || value < 1)
                Console.WriteLine("Invalide value");
            else{
                j+=1;
                l.Add(value);
            }
        }while(value != 0);
        for(int i=0;i < l.Count;i++)
            Console.Write(l[i]+" ");
        Console.WriteLine();
        Console.WriteLine("Which element with is list delete?");
        int index = 0;
        do{
            Console.WriteLine("index ");
            index = Convert.ToInt32(Console.ReadLine());
            if (index < 0 || index >= l.Count)
                Console.WriteLine("Invalide value");
        }while(index < 0 || index >= l.Count);
        
        l.RemoveAt(index);
        for(int i=0;i < l.Count;i++)
            Console.Write(l[i]+" ");
    }
  }
}