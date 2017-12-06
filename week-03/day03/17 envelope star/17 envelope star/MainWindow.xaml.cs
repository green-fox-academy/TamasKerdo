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

namespace _17_envelope_star
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

            int resolution = 1;
            int xstart = 20;
            int ystart = 10;
            int size = 1000;

            int xcenter = xstart + size / 2;
            int ycenter = ystart + size / 2;

            int xposition = xcenter;
            int yposition = 0;

            int i = 0;
            while (yposition < ycenter)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(xcenter, yposition, xcenter - resolution * i, ycenter);
                yposition += resolution;
                i++;
            }

            xposition = xcenter;
            yposition = 0;

            i = 0;
            while (yposition < ycenter)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(xcenter, yposition, xcenter + resolution * i, ycenter);
                yposition += resolution;
                i++;
            }

            xposition = xcenter;
            yposition = xcenter+size/2;
            i = 0;
            while (yposition > ycenter)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(xcenter, yposition, xcenter - resolution * i, ycenter);
                yposition -= resolution;
                i++;
            }

            xposition = xcenter;
            yposition = xcenter + size/2;
            i = 0;
            while (yposition > ycenter)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(xcenter, yposition, xcenter + resolution * i, ycenter);
                yposition -= resolution;
                i++;
            }
        } 
    }
}
