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

namespace Colored_box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            // draw a box that has different colored lines on each edge.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0,0,30,0);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(30, 0, 30, 50);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(30, 50, 0, 50);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 50, 0, 0);





        }
    }
}
