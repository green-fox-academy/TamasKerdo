using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace RPG_Game
{
    public class Map
    {
        public int[,] mapPoints { get; set; }
        public string wallImage { get; set; }
        public string FloorImage { get; set; }
        private FoxDraw FoxDraw;

        public Map(FoxDraw FoxDraw)
        {
            wallImage ="Images/wall.png";
            FloorImage = "Images/floor.png";
            this.FoxDraw = FoxDraw;
            mapPoints = new int[,] { { 1, 1, 1, 0, 1, 0, 1, 1, 1, 1 }, { 1, 1, 1, 0, 1, 0, 1, 0, 0, 1 },
                                     { 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 },{ 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 },
                                     { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },{ 1, 0, 1, 0, 1, 1, 1, 1, 0, 1 },
                                     { 1, 0, 1, 0, 1, 0, 0, 1, 0, 1 },{ 1, 1, 1, 1, 1, 0, 0, 1, 0, 1 },
                                     { 1, 0, 0, 0, 1, 1, 1, 1, 0, 1 },{ 1, 1, 1, 0, 1, 0, 0, 1, 0, 1 },
                                     { 1, 0, 1, 0, 1, 0, 1, 1, 1, 1 }};        
        }

        public void GenerateMap()
        {
            for (int i = 0; i < mapPoints.GetLength(0); i++)
            {
                for (int j = 0; j < mapPoints.GetLength(1); j++)
                {
                    if (mapPoints[i, j] == 1)
                    {
                        FoxDraw.AddImage("Images/floor.png", i * 50, j * 50);
                    }
                    else
                    {
                        FoxDraw.AddImage("Images/wall.png", i * 50, j * 50);
                    }                    
                }
            }   
        }
    }
}
