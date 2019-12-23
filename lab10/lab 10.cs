/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
// Загальна частина:
// Створити методи розширення на основі методів із Лабораторної роботи 6.
// Для типу int (пункт 1 лаб.6), string (пункт 2, 4 лаб.6), double (пункт 3 лаб.6), int[] (пункт 7 лаб.6).

// Згідно з номером в списку:
// 9. Створити розширяючий метод для масиву цілих
// чисел, який додає в кінець масиву елемент.

using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Extension methods ~~~");

            Console.WriteLine("Reversing string");
            string str = "Vova loshped!";
            Console.WriteLine(str);
            str.Reverse();
            Console.WriteLine();

            Console.WriteLine("Reversing int");
            int num = 12312312;
            Console.WriteLine(num);
            num.Reverse();
            Console.WriteLine();

            Console.WriteLine("Reversing double");
            double dNum = 123.567;
            Console.WriteLine(dNum);
            dNum.Reverse();
            Console.WriteLine();

            //reverse array
            Console.WriteLine("Reversing int array");
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            arr.Reverse();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //sort
            Console.WriteLine("\nadd element in array");
            int[] negArr = { -1, 12, 5, 10, -12, 10, -99 };

            for (int i = 0; i < negArr.Length; i++)
            {
                Console.Write(negArr[i] + " ");
            }
            Console.WriteLine();
            negArr.AddElementInArr(100);
        }
    }

    public static class VovanExtensionMethods
    {
            //reverse string method
        //for string
        public static void Reverse(this string getString)
        {
            char[] strArr = getString.ToCharArray();
            for (int i = strArr.Length - 1; i >= 0; i--)
                Console.Write(strArr[i]);
        }
        
        //for double
        public static void Reverse(this double getDouble)
        {
            string[] a = getDouble.ToString().Split ('.');
            a[0].ToString().Reverse();
            Console.Write(".");
            a[1].ToString().Reverse();
        }
        //for int
        public static void Reverse(this int getInt)
        {
            string num = getInt.ToString();
            num.Reverse();
        }
        //for int array
        public static void Reverse(this int[] arr)
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
        }
        public static void AddElementInArr(this int[] arr, int new_el){
            int[] new_arr = new int[arr.Length + 1];
            Console.WriteLine("add element:"+new_el);
            for(int i = 0; i< arr.Length; i++)
                new_arr[i] = arr[i];
            new_arr[arr.Length] = new_el;
            for(int i = 0; i< new_arr.Length; i++) 
                Console.Write(new_arr[i] + " ");
            Console.WriteLine();
            
        }
        
    }

}