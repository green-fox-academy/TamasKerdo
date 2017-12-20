using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Character
    {
        public int HP { get; set; }
        public int DP { get; set; }
        public int SP { get; set; }
        public int[] position { get; set; }
        public string basicLookout { get; set; }
        public bool alive { get; set; }

        public Character()
        {
            position = new int[2];
            alive = true;
        }

        public void GetHit(int HitAmount) => HP = HP - HitAmount;
    }
}
