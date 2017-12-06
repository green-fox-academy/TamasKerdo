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

namespace Connetct_the_dots
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
            // create a function that takes 1 parameter:
            // a list of (x, y) points
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}
            var pointList = new List< Point > ();
            var points = new Point(50, 100);
            pointList.Add(points);

            
            pointList.Add(new Point(70, 70));
            pointList.Add(new Point(80, 90));
            pointList.Add(new Point(90, 90));
            pointList.Add(new Point(100, 70));

            pointList.Add(new Point(120, 100));
            pointList.Add(new Point(85, 130));
            pointList.Add(new Point(50, 100));



            PointDrawer(pointList);
        }

        public void PointDrawer(List<Point> points)
        {
            var foxDraw = new FoxDraw(canvas);
            
            foxDraw.DrawPolygon(points);
        }
    }
}
