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

namespace fill_the_reactangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            int xposition = 5;
            int yposition = 10;
            int height = 50;
            int width = 10;
            int color = 0;

            for (int i = 0; i < 4; i++)
            {
                xposition += 10;
                yposition += 20;
                height += 10;
                width += 5;               
                Reactangle(xposition, yposition, width, height, color);
                color++;
            }

        }

        public void Reactangle(int xposition, int yposition, int width, int height, int color)
        {
            var foxDraw = new FoxDraw(canvas);
            switch (color)
            {
                case 0:

                    foxDraw.FillColor(Colors.Green);
                    foxDraw.DrawRectangle(xposition, yposition, width, height);
                    break;
                case 1:

                    foxDraw.FillColor(Colors.Red);
                    foxDraw.DrawRectangle(xposition, yposition, width, height);
                    break;
                case 2:

                    foxDraw.FillColor(Colors.Blue);
                    foxDraw.DrawRectangle(xposition, yposition, width, height);
                    break;
                case 3:

                    foxDraw.FillColor(Colors.Yellow);
                    foxDraw.DrawRectangle(xposition, yposition, width, height);
                    break;
            }
        }
    }
}
