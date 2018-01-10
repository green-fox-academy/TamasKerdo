using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameForDemo.Models;

namespace GameForDemo.ViewModel
{
    public class ImageViewModel
    {
        public List<HackerImage> ImageList { get; set; }
        public List<StartImage> StartImageList { get; set; }

        public void GenerateImageList()
        {
            var linkList = new List<string>();
            linkList[0] = @"D:\Greenfox Academy tananyag\practice\week07\day3\images\admin.jpg";
            linkList[1] = @"D:\Greenfox Academy tananyag\practice\week07\day3\images\geek.jpg";
            linkList[2] = @"D:\Greenfox Academy tananyag\practice\week07\day3\images\hacker.jpg";

            var rn = new Random();
            int hackerNumber=0;
            for (int i = 0; i < 3; i++)
            {                
                int generatedRandomNumber = rn.Next(0, linkList.Count);
                ImageList.Add(new HackerImage());
                ImageList[i].ImageLink = linkList[generatedRandomNumber];
                ImageList[i].IsThisAHacker = false;

                if (i == 0)
                {
                    hackerNumber = generatedRandomNumber;
                }
            }
            ImageList[hackerNumber].IsThisAHacker = true;            
        }
    }
}
