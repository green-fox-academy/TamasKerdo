using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Garden
    {
        public List<Tree> TreeList { get; set; }
        public List<Flower> FlowerList { get; set; }
        public int WateringNumber { get; set; }

        public Garden()
        {
            TreeList = new List<Tree>();
            FlowerList = new List<Flower>();
            WateringNumber = 0;
        }

        public void AddTree(Tree tr)
        {
            TreeList.Add(tr);
        }
        public void AddFlower(Flower fl)
        {
            FlowerList.Add(fl);
        }

        public void Watering()
        {
            WateringNumber++;
            int NeedWater = 0;

            foreach (var Tree in TreeList)
            {
                if (Tree.WaterAmount < 10)
                {
                    NeedWater++;
                }                
            }
            if (WateringNumber < 2)
            {
                foreach (var Tree in TreeList)
                {
                    if (Tree.WaterAmount < 10)
                    {
                        Tree.GiveWater(40 / NeedWater);
                    }
                }
            }
            else
            {
                foreach (var Tree in TreeList)
                {
                    if (Tree.WaterAmount < 10)
                    {
                        Tree.GiveWater(70 / NeedWater);
                    }
                }
            }
            NeedWater = 0;
            foreach (var Flower in FlowerList)
            {
                if (Flower.WaterAmount < 10)
                {
                    NeedWater++;
                }
            }
            if (WateringNumber < 2)
            {
                foreach (var Flower in FlowerList)
                {
                    if (Flower.WaterAmount < 5)
                    {
                        Flower.GiveWater(40 / NeedWater);
                    }
                }
            }
            else
            {
                foreach (var Flower in FlowerList)
                {
                    if (Flower.WaterAmount < 5)
                    {
                        Flower.GiveWater(70 / NeedWater);
                    }
                }
            }
        }

        public void getStatus()
        {
            foreach (var Tree in TreeList)
            {
                Console.WriteLine(Tree.GetStatus());
            }

            foreach (var Flower in FlowerList)
            {
                Console.WriteLine(Flower.GetStatus());
            }
        }
    }
}
