using System;
using System.Collections;
using System.Collections.Generic;

namespace UsingList
{
    class MainApp
    {
        static void arraylistPrint(ArrayList al)
        {
            foreach (object obj in al)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            arraylistPrint(list); // 0 1 2 3 4

            list.RemoveAt(2);
            arraylistPrint(list); // 0 1 3 4

            list.Insert(1, 5);
            arraylistPrint(list); // 0 5 1 3 4
            
            list.Add("abc");
            list.Add("def"); // 0 5 1 3 4 abc def

            Console.WriteLine(list.Count); // 7

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }
    }
}
