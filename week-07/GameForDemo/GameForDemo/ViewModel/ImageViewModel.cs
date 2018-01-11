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
        public int GameOver { get; set; } = 0;
        public int CardToCheck { get; set; }

        public void GenerateImageList()
        {
            var linkList = new List<string>();
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\admin.jpg");
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\a.jpg");
            linkList.Add(@"D:\Greenfox Academy tananyag\practice\week07\day3\images\hacker.jpg");
            string StartImageLink = @"D:\Greenfox Academy tananyag\practice\week07\day3\images\question.jpg";
            var rn = new Random();
            int hackerNumber=0;
            for (int i = 0; i < 3; i++)
            {                
                int generatedRandomNumber = rn.Next(0, linkList.Count);
                ImageList.Add(new HackerImage());
                ImageList[i].ImageLink = linkList[generatedRandomNumber];
                ImageList[i].IsThisAHacker = false;
                linkList.RemoveAt(generatedRandomNumber);
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

        public void CheckTheCard()
        {
            if (ImageList[CardToCheck].IsThisAHacker)
            {
                GameOver = 2;
                StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
            }
            else if (!StartImageList[CardToCheck].Modified)
            {
                StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
                StartImageList[CardToCheck].Modified = true;
            }
        }

        public void CheckNumberOfModifications()
        {
            int modificationNumber = 0;
            foreach (var startImage in StartImageList)
            {
                if (startImage.Modified == true)
                {
                    modificationNumber++;
                }
            }
            if (modificationNumber>1)
            {
                GameOver = 1;
            }
        }
    }
}
