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

namespace square_positioning
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
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.            
            int Xpos = 0;
            int Ypos = 0;

            for (int i = 0; i < 3; i++)
            {
                SquareDraw(Xpos, Ypos);
                Xpos += 40;
                Ypos += 30;
            }
        }

        public void SquareDraw(int Xpos, int Ypos)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawRectangle(Xpos, Ypos, 50, 50);
        }
    }
}
