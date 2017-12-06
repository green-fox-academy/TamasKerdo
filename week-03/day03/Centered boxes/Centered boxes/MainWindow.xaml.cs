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

namespace Centered_boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

            int squareSize = 20;

            for (int i = 0; i < 3; i++)
            {
                squareSize += 20;
            }

            SquareDrawer(squareSize);
        }

        public void SquareDrawer(int squareSize)
        {
            var foxDraw = new FoxDraw(canvas);
            int xpos=350/2-squareSize / 2;
            int ypos=525/2- squareSize / 2;
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawRectangle(ypos,xpos, squareSize, squareSize);
        }
    }
}
