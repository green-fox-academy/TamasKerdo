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
            FoxCharacter = new FoxDraw(canvas);

            GameLogic = new GameLogic(FoxMap);
            GameLogic.GenerateMap();           
            GameLogic.PlaceTheCharacters(FoxCharacter);
            
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                GameLogic.MoveHero(0, FoxCharacter);               
            }

            if (e.Key == Key.S)
            {
                GameLogic.MoveHero(1, FoxCharacter);
            }

            if (e.Key == Key.D)
            {
                GameLogic.MoveHero(2, FoxCharacter);
            }

            if (e.Key == Key.A)
            {
                GameLogic.MoveHero(3, FoxCharacter);
            }
            if (e.Key == Key.Space)
            {
                GameLogic.Battle(FoxCharacter);
            }
            GameLogic.MoveEnemies(FoxCharacter);
        }
    }
}
