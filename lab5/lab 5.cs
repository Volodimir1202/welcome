// 9.Дана матриця розміру m * n. Вивести номер її 1) першого; 2)
// останнього рядка (стовпчика), що містить тільки додатні елементи.
// Якщо таких рядків (стовпчиків) немає, то вивести 0.
using System;

namespace Rextester
{
  public class Program
  {
      public static void Main (string[]args)
    {
        int n = 6,m = 5;
               
        int[,] a = {
            {12,22,3,-1,2},
            {2,22,3,1,2},
            {12,22,3,-1,2},
            {12,22,3,1,2},
            {1,1,1,1,1},
            {1,22,3,-1,2},
        };
    
        int flag1 = -1;
        int flag2 = -1;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++)
                Console.Write(a[i,j] + " ");
            Console.WriteLine();
            
            bool flag = true;
            int j2 = 0;
            while(j2 < m && flag){
                if (a[i,j2] < 0)
                    flag =false;
                j2++;
            }
            if (flag && flag1 == -1 && flag2 == -1)
                flag1 = i;
            else if (flag && flag1 != -1)
                flag2 = i;
        }
        Console.WriteLine("indexs positiv cols");
        Console.WriteLine(flag1);
        
        for(int j = 0; j < m; j++)
            Console.Write(a[flag1,j] + " ");
        Console.WriteLine();
        Console.WriteLine(flag2);
        
        for(int j = 0; j < m; j++)
            Console.Write(a[flag2,j] + " ");
        
    }
  }
}