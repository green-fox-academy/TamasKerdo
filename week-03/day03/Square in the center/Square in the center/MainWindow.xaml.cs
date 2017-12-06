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

namespace Square_in_the_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // draw a green 10x10 square to the canvas' center.
            
            int width = 10;
            Square(width);
        }

        public void Square(int width)
        {
            var foxDraw = new FoxDraw(canvas);
            int centerHeight = 525 / 2;
            int centerWidth = 350 / 2;
            foxDraw.StrokeColor(Colors.Red);
                      
            foxDraw.DrawRectangle( centerHeight+width/2,centerWidth + width / 2, width,width);
            
        }
    }
}
