using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media.Imaging;
using System.Windows;

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
            mapPoints = new int[,] { {1, 1, 1, 0, 1, 0, 1, 1, 1, 1},
                                     {1, 1, 1, 0, 1, 0, 1, 0, 0, 1},
                                     {1, 0, 0, 0, 1, 0, 1, 0, 0, 1},
                                     {1, 1, 1, 1, 1, 0, 1, 1, 1, 1},
                                     {0, 0, 0, 0, 1, 0, 1, 1, 0, 1},
                                     {1, 0, 1, 0, 1, 1, 1, 1, 0, 1},
                                     {1, 0, 1, 0, 1, 0, 1, 1, 0, 1},
                                     {1, 1, 1, 1, 1, 0, 1, 1, 0, 0},
                                     {1, 0, 0, 0, 1, 1, 1, 1, 0, 1},
                                     {1, 1, 1, 0, 1, 0, 0, 1, 0, 1},};


            CharacterList = new List<Character>();
        }

        public void AddToCharacterList(Character character)
        {
            CharacterList.Add(character);
        }

        public void GenerateMap()
        {
            for (int row = 0; row < mapPoints.GetLength(0); row++)
            {
                for (int col = 0; col < mapPoints.GetLength(1); col++)
                {
                    if (mapPoints[row, col] == 1)
                    {
                        FoxMap.AddImage("Images/floor.png", col * 50, row * 50);
                    }
                    else
                    {
                        FoxMap.AddImage("Images/wall.png", col * 50, row * 50);
                    }
                }
            }
        }

        public bool CanTheCharacterStepThere(int x, int y)
        {
            x = x / 50;
            y = y / 50;
            bool returnValue = false;

            if (((x < 10) && (x >= 0)) && ((y < 10) && (y >= 0)))
            {
                if (mapPoints[y, x] == 1)
                {
                    returnValue = true;
                }                
            }
            return returnValue;
        }

        public void PlaceTheCharacters(FoxDraw FoxCharacter)
        {
            int x = 0;
            int y = 0;
            var hero = new Hero(y,x);
            FoxCharacter.AddImage(hero.basicLookout, hero.position[0], hero.position[1]);
            var rn = new Random();
            AddToCharacterList(hero);

            y = rn.Next(0, 10);
            x = rn.Next(0, 10);
            while (FoxCharacter.Tiles.Count<2)
            {
                if (mapPoints[y, x] == 1)
                {                   
                    var boss = new Boss(x * 50, y * 50, 1);
                    FoxCharacter.AddImage(boss.basicLookout, boss.position[0], boss.position[1]);
                    AddToCharacterList(boss);

                }
                y = rn.Next(0, 10);
                x = rn.Next(0, 10);
            }
            int keyPosition = rn.Next(2, 10);
            y = rn.Next(0, 10);
            x = rn.Next(0, 10);
            for (int i = 2; i < 9; i++)
            {
                while (FoxCharacter.Tiles.Count < i)
                {
                    if (mapPoints[y, x] == 1)
                    {                        
                        if (keyPosition == i)
                        {
                            var monster = new Monster(x * 50, y * 50, true, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                            AddToCharacterList(monster);
                        }
                        else
                        {
                            var monster = new Monster(x * 50, y * 50, false, 1);
                            FoxCharacter.AddImage(monster.basicLookout, monster.position[0], monster.position[1]);
                            AddToCharacterList(monster);
                        }                        
                    }
                    y = rn.Next(0, 10);
                    x = rn.Next(0, 10);
                }
            }            
        }

        public void MoveHero(int direction, FoxDraw FoxCharacter)
        {
            if (CharacterList[0].alive == true)
            {
                int x = 0;
                int y = 0;
                switch (direction)
                {
                    case 0:

                        x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
                        y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) - 50;

                        if (CanTheCharacterStepThere(x, y))
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

                        if (CanTheCharacterStepThere(x, y))
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

                        if (CanTheCharacterStepThere(x, y))
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

                        if (CanTheCharacterStepThere(x, y))
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
                if (CharacterList[i].alive == true)
                {
                    switch (rn.Next(0, 4))
                    {
                        case 0:
                            if (CanTheCharacterStepThere(x, y - 50))
                            {
                                FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x, y - 50);
                            }
                            break;
                        case 1:
                            if (CanTheCharacterStepThere(x + 50, y))
                            {
                                FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x + 50, y);
                            }
                            break;
                        case 2:
                            if (CanTheCharacterStepThere(x, y + 50))
                            {
                                FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x, y + 50);
                            }
                            break;
                        case 3:
                            if (CanTheCharacterStepThere(x - 50, y))
                            {
                                FoxCharacter.SetPosition(FoxCharacter.Tiles[i], x - 50, y);
                            }
                            break;
                        default:
                            break;
                    }
                }
               
            }            
        }

        public int[] GetHeroStatus()
        {
            var heroData = new int[10];
            heroData[0] = CharacterList[0].HP;
            heroData[1] = CharacterList[0].DP;
            heroData[2] = CharacterList[0].SP;

            return heroData;
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
                    CharacterList[i].HP = CharacterList[i].HP - 10;                    

                    if (CharacterList[i].HP > 0)
                    {
                        CharacterList[0].HP = CharacterList[0].HP - Math.Abs(CharacterList[0].DP - CharacterList[i].SP);
                        if (CharacterList[0].HP<0)
                        {
                            CharacterList[0].alive = false;
                            FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/ash.png", UriKind.Relative));
                            MessageBox.Show("Game Over");
                        }
                    }
                    else
                    {
                        FoxCharacter.Tiles[i].Source = new BitmapImage(new Uri("Images/ash.png", UriKind.Relative));
                        CharacterList[i].alive = false;
                        CharacterList[0].Leveling();
                    }
                }
            }            
        }
    }
}
