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

namespace Middle_lines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.


            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 10, 100, 10);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 40, 100, 40);
        }
    }
}
