using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_6
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            //Solution 1


            var listElement = new List<int>();
            listElement.Add(4);
            listElement.Add(8);
            listElement.Add(12);
            listElement.Add(16);

            for (int i = 0; i < listElement.Count; i++)
            {
                if (list.Contains(listElement[i]))
                {
                    listElement[i] = 1;
                }
                else
                {
                    listElement[i] = 0;
                }
            }
            if (listElement.Contains(0))
            {
                Console.WriteLine("false1");
            }
            else
            {
                Console.WriteLine("true1");
            }



            //Solution 2

            int[] elements = new int[4] {4, 8, 12, 16};

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Equals(elements[i]) == true)
                    {
                        elements[i] = 1;
                        
                    }
                    
                }
                if (elements[i] != 1 || (i == elements.Length))
                {
                    Console.WriteLine("false2");
                }
                
                
            }
            Console.ReadLine();

        }
    }
}
