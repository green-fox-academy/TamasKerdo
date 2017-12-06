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

namespace To_the_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            int x = 10;
            int y = 10;
            linedraw(x,y);
        }

        public void linedraw(int x, int y)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(x, y,263, 175);
        }
    }
}
