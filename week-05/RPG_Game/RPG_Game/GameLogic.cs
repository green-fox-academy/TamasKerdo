using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media.Imaging;

namespace RPG_Game
{
    public class GameLogic
    {
        public int[,] mapPoints { get; set; }
        public string wallImage { get; set; }
        public string FloorImage { get; set; }
        private FoxDraw FoxMap;
        private List<Character> CharacterList;

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
                                     {0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                                     {0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0 },
                                     {0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0 },
                                     {0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0 },
                                     {0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0 },
                                     {0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

            CharacterList = new List<Character>();
        }

        public void AddToCharacterList(Character character)
        {
            CharacterList.Add(character);
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
            int x = 0;
            int y = 0;
            var hero = new Hero(x,y);
            FoxCharacter.AddImage(hero.basicLookout, hero.position[0], hero.position[1]);
            var rn = new Random();
            AddToCharacterList(hero);

            y = rn.Next(1, 11);
            x = rn.Next(1, 12);
            while (FoxCharacter.Tiles.Count<2)
            {
                if (mapPoints[y, x] == 1)
                {                   
                    var boss = new Boss((x - 1) * 50, (y - 1) * 50, 1);
                    FoxCharacter.AddImage(boss.basicLookout, boss.position[0], boss.position[1]);
                    AddToCharacterList(boss);

                }
                y = rn.Next(1, 11);
                x = rn.Next(1, 12);
            }
            int keyPosition = rn.Next(2, 10);
            y = rn.Next(1, 11);
            x = rn.Next(1, 12);
            for (int i = 2; i < 9; i++)
            {
                while (FoxCharacter.Tiles.Count < i+1)
                {
                    if (mapPoints[y, x] == 1)
                    {                        
                        if (keyPosition == i)
                        {
                            var monster = new Monster((x - 1) * 50, (y - 1) * 50, true, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                            AddToCharacterList(monster);
                        }
                        else
                        {
                            var monster = new Monster((x - 1) * 50, (y - 1) * 50, false, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                            AddToCharacterList(monster);
                        }                        
                    }
                    y = rn.Next(1, 11);
                    x = rn.Next(1, 12);
                }
            }            
        }

        public void MoveHero(int direction, FoxDraw FoxCharacter)
        {
            int x = 0;
            int y = 0;
            switch (direction)
            {
                case 0:
                    x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
                    y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) - 50;
                    if (CanTheCharacterStepThere(x, y, 2))
                    {
                        FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-up.png", UriKind.Relative));
                    }
                    else
                    {
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-up.png", UriKind.Relative));
                    }
                    break;
                case 1:
                    x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
                    y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) + 50;
                    if (CanTheCharacterStepThere(x, y, 0))
                    {
                        FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-down.png", UriKind.Relative));
                    }
                    else
                    {
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-down.png", UriKind.Relative));
                    }
                    break;
                case 2:
                    x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]) + 50;
                    y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]);
                    if (CanTheCharacterStepThere(x, y, 1))
                    {
                        FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-right.png", UriKind.Relative));
                    }
                    else
                    {
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-right.png", UriKind.Relative));
                    }
                    break;
                case 3:
                    x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]) - 50;
                    y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]);
                    if (CanTheCharacterStepThere(x, y, 3))
                    {
                        FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-left.png", UriKind.Relative));
                    }
                    else
                    {
                        FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-left.png", UriKind.Relative));
                    }
                    break;
                default:
                    break;
            }
        }

        
        public void MoveEnemies(FoxDraw FoxCharacter)
        {
            int x = 0;
            int y = 0;
            var rn = new Random();
            
            for (int i = 1; i < FoxCharacter.Tiles.Count; i++)
            {
                x = FoxCharacter.GetLeft(FoxCharacter.Tiles[i]);
                y = FoxCharacter.GetTop(FoxCharacter.Tiles[i]);
                
                switch (rn.Next(0, 4))
                {
                    case 0:
                        if (CanTheCharacterStepThere(x, y - 50, 0))
                        {
                            FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x, y - 50);
                        }
                        break;
                    case 1:
                        if (CanTheCharacterStepThere(x + 50, y, 1))
                        {
                            FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x + 50, y);
                        }
                        break;
                    case 2:
                        if (CanTheCharacterStepThere(x, y + 50, 2))
                        {
                            FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x, y + 50);
                        }
                        break;
                    case 3:
                        if (CanTheCharacterStepThere(x - 50, y, 3))
                        {
                            FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x - 50, y);
                        }
                        break;
                    default:
                        break;
                }                
            }            
        }

        public void Battle(FoxDraw FoxCharacter)
        {
            int xHero = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
            int yHero = FoxCharacter.GetTop(FoxCharacter.Tiles[0]);
            int xEnemy = 0;
            int yEnemy = 0;

            for (int i = 1; i < FoxCharacter.Tiles.Count; i++)
            {
                xEnemy = FoxCharacter.GetLeft(FoxCharacter.Tiles[i]);
                yEnemy = FoxCharacter.GetTop(FoxCharacter.Tiles[i]);
                if ((xHero == xEnemy)&&(yHero ==yEnemy))
                {
                    CharacterList[i].HP = CharacterList[0].DP - CharacterList[0].SP;
                }
            }

        }
    }
}
