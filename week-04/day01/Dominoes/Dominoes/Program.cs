using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the dominoes in this form: int int");

            Console.WriteLine(@"Press a number>10 if you want to order the added elements like this: 11 11");

            List<DominoBrick> DominoList = new List<DominoBrick>();
            GetUserInput(DominoList);
            
            foreach (var ListElement in OrderDominoBricks(DominoList))
            {
                Console.WriteLine("[" + ListElement.ASide +" "+ ListElement.BSide + "]");
            }
            Console.ReadLine();
        }


        public static List<DominoBrick> GetUserInput(List<DominoBrick> DominoList)
        {
            bool addElement = true;
            int AInput;
            int BInput;

            string input;
            string[] array = new string[2];            

            while (addElement == true)
            {
                input = Console.ReadLine();
                array = input.Split(' ');
                Int32.TryParse(array[0], out AInput);
                Int32.TryParse(array[1], out BInput);

                if (AInput > 0 && AInput < 10 && BInput > 0 && BInput < 10)
                {
                    DominoList.Add(new DominoBrick(AInput, BInput));
                }
                else
                {
                    addElement = false;
                }
            }
            return DominoList;
        }

        public static List<DominoBrick> OrderDominoBricks(List<DominoBrick> DominoList)
        {
            List<DominoBrick> OrderedDominoList = new List<DominoBrick>();
            OrderedDominoList.Add(DominoList[0]);
            DominoList.RemoveAt(0);

            while (DominoList.Count > 0)
            {
                int element = 0;
                for(int i = 0; i<DominoList.Count;i++)
                {
                    if (OrderedDominoList[0].ASide == DominoList[i].BSide)
                    {
                        OrderedDominoList.Insert(0, DominoList[i]);
                        element = i;
                        break;


                    }
                    else if (OrderedDominoList[0].ASide == DominoList[i].ASide)
                    {
                        DominoList[i].flipElement();
                        OrderedDominoList.Insert(0, DominoList[i]);
                        element = i;
                        break;
                    }
                    else if (OrderedDominoList[OrderedDominoList.Count - 1].BSide == DominoList[i].ASide)
                    {

                        OrderedDominoList.Add(DominoList[i]);
                        element = i;
                        break;
                    }
                    else if (OrderedDominoList[OrderedDominoList.Count - 1].BSide == DominoList[i].BSide)
                    {
                        DominoList[i].flipElement();
                        OrderedDominoList.Add(DominoList[i]);
                        element = i;
                        break;

                    }
                    else if (i == DominoList.Count - 1)
                    {
                        OrderedDominoList.Add(DominoList[0]);
                        element = 0;
                    }
                    
                }
                DominoList.RemoveAt(element);

            }                         
            return OrderedDominoList;
        }
    }
}
