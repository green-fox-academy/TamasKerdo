using System;

namespace Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
        }
        
        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(object DominoToCompare)
        {
            int returnNumber = 0;
            if (DominoToCompare is Domino)
            {
                if ((DominoToCompare as Domino).Values[0] < Values[0])
                {
                    returnNumber = 1;
                }
                else if((DominoToCompare as Domino).Values[0] > Values[0])
                {
                    returnNumber = -1;
                }
                else
                {
                    if ((DominoToCompare as Domino).Values[1] < Values[1])
                    {
                        returnNumber = 1;
                    }
                    else if ((DominoToCompare as Domino).Values[1] > Values[1])
                    {
                        returnNumber = -1;
                    }
                    else
                    {
                        returnNumber = 0;
                    }
                }                
            }
            return returnNumber;
        }
    }
}
