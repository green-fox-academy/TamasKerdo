using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameForDemo.Models;

namespace GameForDemo.ViewModel
{
    public class ImageViewModel
    {
        public List<HackerImage> ImageList { get; set; } = new List<HackerImage>();
        public List<StartImage> StartImageList { get; set; } = new List<StartImage>();

        public void GenerateImageList()
        {
            var linkList = new List<string>();
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\admin.jpg");
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\geek.jpg");
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\hacker.jpg");
            string StartImageLink = @"d:\Greenfox Academy tananyag\practice\week07\day3\images\question.jpg";
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

            for (int i = 0; i < 3; i++)
            {
                StartImageList.Add(new StartImage());
                StartImageList[i].StartImageLink = StartImageLink;
                StartImageList[i].Modified = false;
            }
        }
    }
}
