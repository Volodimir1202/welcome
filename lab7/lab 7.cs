// Написати програму, що виконує наступні функції:
// 1. Виводить на екран введене число з клавіатури в зворотному порядку (1234-&gt;4321)
// 2. Виводить будь-яку строку в зворотному порядку (АБВ-&gt;ВБА)
// 3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456-
// &gt;321.654)
// 4. Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного
// знаку” теж в зворотному (АБВ,ГДЕ-&gt;ВБА,ЕДГ)
// 5. Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних
// типів
// 6. Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів
// перевантажити
// 7. Реалізувати метод, що буде масив повертати задом навпаки (Використання
// Array.Reverse() заборонено!)
// 8. Виконати пункт 7 з використанням ключових слів ref i out

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
  public class Program
  {
      public static void Main (string[]args)
    {
      //1
      Console.Write ("1)");
      int first = 1234;
      Console.Write (first + "->");
      Task1 (first);
      Console.WriteLine ();
      //2
      Console.Write ("2)");
      string second = "aDVS";
      Console.Write (second + "->");
      Task2 (second);
      Console.WriteLine ();
      //3
      Console.Write ("3)");
      double third = 15.35;
      Console.Write (third + "->");
      Task3 (third);
      Console.WriteLine();
      //4
      Console.Write ("4)");
      string fourth = "qwerty,uiop,[]";
      char sumvol = ',';
      Console.Write (fourth + "->");
      Task4(fourth,sumvol);
      Console.WriteLine();
      //5
      Console.Write ("5.1)");
      Console.Write (first + "->");
      Task5(first);
      Console.WriteLine();
      
      Console.Write ("5.2)");
      Console.Write (second + "->");
      Task5(second);
      Console.WriteLine();
      
      Console.Write ("5.3)");
      Console.Write (third + "->");
      Task5(third);
      Console.WriteLine();
            
      Console.Write ("5.4)");
      Console.Write (fourth + "->");
      Task5(fourth, sumvol);
      Console.WriteLine();
    
       //7
      Console.Write ("7)");
      int[] a = {0, 2, 3, 4, 5}; 
      for(int i =0;i<a.Length;i++)
        Console.Write(a[i] +" ");
      Console.Write ("-> ");
      Task7(a);
    }
      
      
    //reverse string method
        
    //task 1
        public static void Task1(int getInt)
        {
            string num = getInt.ToString();
            Task2(num);
        }
      
      //task 2
        public static void Task2(string getString)
        {
            char[] strArr = getString.ToCharArray();
            for (int i = strArr.Length - 1; i >= 0; i--)
                Console.Write(strArr[i]);
        }
        
        //Task3
        public static void Task3( double getDouble)
        {
            string[] a = getDouble.ToString().Split ('.');
            Task2(a[0].ToString());
            Console.Write(".");
            Task2(a[1].ToString());
        }
  
      //Task 4
    public static void Task4 (string getString, char sumvol) {
      string[] a = getString.ToString ().Split (sumvol);
      for (int i = 0; i < a.Length - 1; i++)
    	{
    	  Task2 (a[i]);
    	  Console.Write (sumvol);
    	}
      Task2 (a[a.Length - 1]);
    }

          //Task5.1
        public static void Task5( int getInt)
        {
            string num = getInt.ToString();
            Task5(num);
        }
          //Task5.2
        public static void Task5( string getString)
        {
            char[] strArr = getString.ToCharArray();
            for (int i = strArr.Length - 1; i >= 0; i--)
                Console.Write(strArr[i]);
        }
        
          //Task5.3
        public static void Task5( double getDouble)
        {
            string[] a = getDouble.ToString().Split ('.');
            Task2(a[0].ToString());
            Console.Write(".");
            Task2(a[1].ToString());
        }
      //Task5.4
    public static void Task5 (string getString, char sumvol) {
      string[] a = getString.ToString ().Split (sumvol);
      for (int i = 0; i < a.Length - 1; i++)
    	{
    	  Task2 (a[i]);
    	  Console.Write (sumvol);
    	}
      Task2 (a[a.Length - 1]);
    }
    //Task 7
    public static void Task7(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;

                left++;
                right--;
            }
            for(int i =0;i<arr.Length;i++)
                Console.Write(arr[i] +" ");
        }
    
  }
}