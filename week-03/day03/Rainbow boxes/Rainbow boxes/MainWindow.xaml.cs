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

namespace Rainbow_boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            int size = 300;
            int color = 0;
            for (int i = 0; i < 7; i++)
            {
                
                
                SquareDrawer(size, color);
                size -= 40;
                color++;
            }
        }

        public void SquareDrawer(int size, int color)
        {
            var foxDraw = new FoxDraw(canvas);
            int xparam = 525 / 2 - size / 2;
            int yparam = 350 / 2 - size / 2;
            switch (color)
            {
                case 0:
                    foxDraw.StrokeColor(Colors.Red);
                    foxDraw.FillColor(Colors.Red);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 1:
                    foxDraw.StrokeColor(Colors.Orange);
                    foxDraw.FillColor(Colors.Orange);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 2:
                    foxDraw.StrokeColor(Colors.Yellow);
                    foxDraw.FillColor(Colors.Yellow);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 3:
                    foxDraw.StrokeColor(Colors.Green);
                    foxDraw.FillColor(Colors.Green);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 4:
                    foxDraw.StrokeColor(Colors.Blue);
                    foxDraw.FillColor(Colors.Blue);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 5:
                    foxDraw.StrokeColor(Colors.Violet);
                    foxDraw.FillColor(Colors.Violet);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
                case 6:
                    foxDraw.StrokeColor(Colors.Pink);
                    foxDraw.FillColor(Colors.Pink);
                    foxDraw.DrawRectangle(xparam, yparam, size, size);
                    break;
            }

            }
        }
    }
