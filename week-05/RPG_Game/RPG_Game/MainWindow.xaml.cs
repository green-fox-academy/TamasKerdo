using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPG_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private FoxDraw FoxCharacter;
        private GameLogic GameLogic;

        public MainWindow()
        {
            InitializeComponent();
            var FoxMap = new FoxDraw(canvas);
            GameLogic = new GameLogic(FoxMap);
            GameLogic.GenerateMap();

            FoxCharacter = new FoxDraw(canvas);
            
            FoxCharacter.AddImage("Images/hero-down.png", 0,0);
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                int x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
                int y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) - 50;
                if (GameLogic.CanTheCharacterStepThere(x, y, 2))
                {                    
                    FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-up.png", UriKind.Relative));
                }
                else
                {
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-up.png", UriKind.Relative));
                }                
            }

            if (e.Key == Key.S)
            {
                int x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]);
                int y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) + 50;
                if (GameLogic.CanTheCharacterStepThere(x, y, 0))
                {                    
                    FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-down.png", UriKind.Relative));
                }
                else
                {
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-down.png", UriKind.Relative));
                }
            }

            if (e.Key == Key.D)
            {
                int x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]) + 50;
                int y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]) ;
                if (GameLogic.CanTheCharacterStepThere(x, y, 1))
                {                    
                    FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-right.png", UriKind.Relative));
                }
                else
                {
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-right.png", UriKind.Relative));
                }
            }

            if (e.Key == Key.A)
            {
                int x = FoxCharacter.GetLeft(FoxCharacter.Tiles[0]) - 50;
                int y = FoxCharacter.GetTop(FoxCharacter.Tiles[0]);
                if (GameLogic.CanTheCharacterStepThere(x, y, 3))
                {                    
                    FoxCharacter.SetPosition(FoxCharacter.Tiles[0], x, y);
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-left.png", UriKind.Relative));
                }
                else
                {
                    FoxCharacter.Tiles[0].Source = new BitmapImage(new Uri("Images/hero-left.png", UriKind.Relative));
                }
            }
        }
    }
}
