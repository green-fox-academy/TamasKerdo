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

namespace Everything_goes_to_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int xposition = 100;
            int yposition = 100;


            StarDrawer(xposition, yposition);
                
        }

        public void StarDrawer(int xstart, int ystart)
        {
            var foxDraw = new FoxDraw(canvas);
            int xcenter = xstart + 100 / 2;
            int ycenter = ystart + 100 / 2;
            int xposition = xstart;
            int yposition = ystart;


            while (xposition < (xcenter + 100/2))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                xposition += 20;
            }
            while (yposition < (ycenter + 100/2))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                yposition += 20;
            }
            while (xposition > (xcenter - 100/2))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                xposition -= 20;
            }
            while (yposition > (ycenter - 100/2))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                yposition -= 20;
            }
        }
    }
}
