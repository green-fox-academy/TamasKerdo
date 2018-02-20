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
        public int NumberOfDeaths { get; set; }
        public int NumberOfWins { get; set; }

        public void GenerateImageList()
        {
            var linkList = new List<string>();
            linkList.Add(@"/Images/hacker.jpg");
            linkList.Add(@"/Images/admin.jpg");
            linkList.Add(@"/Images/sp.jpg");
            
            string StartImageLink = @"/Images/question.jpg";
            var rn = new Random();
            bool hackerIsAdded=false;
            for (int i = 0; i < 3; i++)
            {                
                int generatedRandomNumber = rn.Next(0, linkList.Count);
                ImageList.Add(new HackerImage());
                if (generatedRandomNumber == 0 && hackerIsAdded == false)
                {
                    hackerIsAdded = true;
                    ImageList[i].IsThisAHacker = true;
                    ImageList[i].ImageLink = linkList[generatedRandomNumber];
                    linkList.RemoveAt(generatedRandomNumber);
                }
                else
                {
                    ImageList[i].ImageLink = linkList[generatedRandomNumber];
                    ImageList[i].IsThisAHacker = false;
                    linkList.RemoveAt(generatedRandomNumber);
                }                             
            }            

            for (int i = 0; i < 3; i++)
            {
                StartImageList.Add(new StartImage());
                StartImageList[i].StartImageLink = StartImageLink;
                StartImageList[i].Modified = false;
            }
        }

        public void CheckTheCard()
        {

            if (CheckNumberOfModifications()== 0)
            {
                if (ImageList[CardToCheck].IsThisAHacker)
                {
                    GameOver = 1;
                    StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
                }
                else if (!StartImageList[CardToCheck].Modified)
                {
                    StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
                    StartImageList[CardToCheck].Modified = true;
                }
            }
            else
            {
                if (ImageList[CardToCheck].IsThisAHacker)
                {
                    GameOver = 1;
                    StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
                }
                else
                {
                    GameOver = 2;
                    StartImageList[CardToCheck].StartImageLink = ImageList[CardToCheck].ImageLink;
                }
            }           
        }

        public int CheckNumberOfModifications()
        {
            int modificationNumber = 0;
            foreach (var startImage in StartImageList)
            {
                if (startImage.Modified == true)
                {
                    modificationNumber++;
                }
            }
            return modificationNumber;
        }
    }
}
