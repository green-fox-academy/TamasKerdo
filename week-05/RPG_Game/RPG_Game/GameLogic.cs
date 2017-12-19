using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace RPG_Game
{
    public class GameLogic
    {
        public int[,] mapPoints { get; set; }
        public string wallImage { get; set; }
        public string FloorImage { get; set; }
        private FoxDraw FoxMap;

        public GameLogic(FoxDraw FoxMap)
        {
            wallImage = "Images/wall.png";
            FloorImage = "Images/floor.png";
            this.FoxMap = FoxMap;
            mapPoints = new int[,] { {0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                     {0 ,1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0 },
                                     {0 ,1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 0 },
                                     {0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 },
                                     {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                                     {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0 },
                                     {0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0 },
                                     {0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0 },
                                     {0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0 },
                                     {0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        }

        public void GenerateMap()
        {
            for (int row = 1; row < mapPoints.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < mapPoints.GetLength(1) - 1; col++)
                {
                    if (mapPoints[row, col] == 1)
                    {
                        FoxMap.AddImage("Images/floor.png", (col - 1) * 50, (row - 1) * 50);
                    }
                    else
                    {
                        FoxMap.AddImage("Images/wall.png", (col - 1) * 50, (row - 1) * 50);
                    }
                }
            }
        }

        public bool CanTheCharacterStepThere(int x, int y, int whereToStep)
        {
            x = (x / 50) + 1;
            y = (y / 50) + 1;
            bool returnValue = true;
            switch (whereToStep)
            {
                case 0:
                    if (mapPoints[y, x] == 1)
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                    break;
                case 1:
                    if (mapPoints[y, x] == 1)
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                    break;
                case 2:
                    if (mapPoints[y, x] == 1)
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                    break;
                case 3:
                    if (mapPoints[y, x] == 1)
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                    break;
            }
            return returnValue;
        }


        public void PlaceTheCharacters(FoxDraw FoxCharacter)
        {
            int x = 1;
            int y = 1;
            var hero = new Hero(x,y);
            FoxCharacter.AddImage(hero.basicLookout, hero.position[0], hero.position[1]);
            var rn = new Random();

            x = rn.Next(1, 12);
            y = rn.Next(1, 11);
            while (FoxCharacter.Tiles.Count<2)
            {
                if (mapPoints[x, y] == 1)
                {                   
                    var boss = new Boss(x*50,y*50,1);
                    FoxCharacter.AddImage(boss.basicLookout, boss.position[0], boss.position[1]);
                    
                }
                x = rn.Next(1, 11);
                y = rn.Next(1, 10);
            }
            int keyPosition = rn.Next(2, 10);
            x = rn.Next(1, 11);
            y = rn.Next(1, 10);
            for (int i = 2; i < 9; i++)
            {
                while (FoxCharacter.Tiles.Count < i+1)
                {
                    if (mapPoints[x, y] == 1)
                    {                        
                        if (keyPosition == i)
                        {
                            var monster = new Monster(x*50, y * 50, true, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                        }
                        else
                        {
                            var monster = new Monster(x * 50, y * 50, false, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                        }                        
                    }
                    x = rn.Next(1, 11);
                    y = rn.Next(1, 10);
                }
            }            
        }
    }
}
