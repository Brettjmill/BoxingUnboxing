using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxList = new List<object>();

            boxList.Add(7);
            boxList.Add(28);
            boxList.Add(-1);
            boxList.Add(true);
            boxList.Add("chair");

            for (int i = 0; i < boxList.Count; i++)
            {
                Console.WriteLine(boxList[i]);
            }

            var total = 0;
            for (int i = 0; i < boxList.Count; i++)
            {
                if (boxList[i] is int)
                {
                    int tempNum = (int)boxList[i];
                    total += tempNum;
                }
            }
            Console.WriteLine(total);
        }
    }
}
