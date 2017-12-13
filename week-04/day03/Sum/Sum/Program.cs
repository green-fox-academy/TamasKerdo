using System;
using System.Collections.Generic;

namespace Sum
{
    public class ListSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int SumListElements(List<int> list)
        {
            int returnValue = 0;
            foreach (var listElement in list)
            {
                returnValue += listElement;
            }
            return returnValue;
        }
    }
}
