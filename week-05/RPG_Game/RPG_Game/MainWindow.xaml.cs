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
using System.Media;

namespace RPG_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private FoxDraw FoxCharacter;
        private GameLogic GameLogic;
        public int[] heroStatusArray;

        public MainWindow()
        {
            InitializeComponent();
            int MapElementSize = 70;
            int NumberOfTheEnemies = 7;

            var FoxMap = new FoxDraw(canvas, MapElementSize);
            FoxCharacter = new FoxDraw(canvas, MapElementSize);
            GameLogic = new GameLogic(FoxMap, MapElementSize, NumberOfTheEnemies);

            GameLogic.GenerateMap();           
            GameLogic.PlaceTheCharacters(FoxCharacter);

            heroStatusArray = GameLogic.GetHeroStatus();
            HeroData.Text = "  HP: " + heroStatusArray[0] + " DP: " + heroStatusArray[1] + " SP: " + heroStatusArray[2];
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                GameLogic.MoveHero(0, FoxCharacter);
            }

            else if (e.Key == Key.S)
            {
                GameLogic.MoveHero(1, FoxCharacter);
            }

            else if (e.Key == Key.D)
            {
                GameLogic.MoveHero(2, FoxCharacter);
            }

            else if (e.Key == Key.A)
            {
                GameLogic.MoveHero(3, FoxCharacter);
            }

            else if (e.Key == Key.Space)
            {
                GameLogic.Battle(FoxCharacter);
                heroStatusArray = GameLogic.GetHeroStatus();
                HeroData.Text = "  HP: " + heroStatusArray[0] + " DP: " + heroStatusArray[1] + " SP: " + heroStatusArray[2];
            }

            GameLogic.MoveEnemies(FoxCharacter);           
        }
    }
}
