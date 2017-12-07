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

namespace _11ReproduceThis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            int xStartpoint = 0;
            int yStartpoint = 0;
            int size = 1000;
            int cycle = 6;
            DrawPlease(xStartpoint, yStartpoint, size, cycle);
            

        }


        public void DrawPlease(int xStartpoint,int yStartpoint,int size,int cycle)
        {
            int pointLenght = size / 3;

            int[] Point00 = new int[2];
            Point00[0] = xStartpoint;
            Point00[1] = yStartpoint;

            int[] Point01 = new int[2];
            Point01[0] = xStartpoint + pointLenght;
            Point01[1] = yStartpoint;                

            int[] Point02 = new int[2];
            Point02[0] = xStartpoint + 2*pointLenght;
            Point02[1] = yStartpoint;

            int[] Point03 = new int[2];
            Point03[0] = xStartpoint + 3*pointLenght;
            Point03[1] = yStartpoint;                //1sor

            int[] Point10 = new int[2];
            Point10[0] = xStartpoint;
            Point10[1] = yStartpoint+pointLenght;

            int[] Point11 = new int[2];
            Point11[0] = xStartpoint + pointLenght;
            Point11[1] = yStartpoint + pointLenght;                

            int[] Point12 = new int[2];
            Point12[0] = xStartpoint + 2 * pointLenght;
            Point12[1] = yStartpoint + pointLenght;

            int[] Point13 = new int[2];
            Point13[0] = xStartpoint + 3 * pointLenght;
            Point13[1] = yStartpoint + pointLenght;     //2sor


            int[] Point20 = new int[2];
            Point20[0] = xStartpoint;
            Point20[1] = yStartpoint + 2*pointLenght;

            int[] Point21 = new int[2];
            Point21[0] = xStartpoint + pointLenght;
            Point21[1] = yStartpoint + 2 * pointLenght;

            int[] Point22 = new int[2];
            Point22[0] = xStartpoint + 2 * pointLenght;
            Point22[1] = yStartpoint + 2 * pointLenght;

            int[] Point23 = new int[2];
            Point23[0] = xStartpoint + 3 * pointLenght;
            Point23[1] = yStartpoint + 2 * pointLenght;      //3sor


            int[] Point30 = new int[2];
            Point30[0] = xStartpoint;
            Point30[1] = yStartpoint + 3 * pointLenght;

            int[] Point31 = new int[2];
            Point31[0] = xStartpoint + pointLenght;
            Point31[1] = yStartpoint + 3 * pointLenght;

            int[] Point32 = new int[2];
            Point32[0] = xStartpoint + 2 * pointLenght;
            Point32[1] = yStartpoint + 3 * pointLenght;

            int[] Point33 = new int[2];
            Point33[0] = xStartpoint + 3 * pointLenght;
            Point33[1] = yStartpoint + 3 * pointLenght;      //4sor

            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(Point01[0], Point01[1], Point31[0], Point31[1]);
            foxDraw.DrawLine(Point02[0], Point02[1], Point32[0], Point32[1]);
            foxDraw.DrawLine(Point10[0], Point10[1], Point13[0], Point13[1]);
            foxDraw.DrawLine(Point20[0], Point20[1], Point23[0], Point23[1]);
            

            if (cycle > 0)
            {
                DrawPlease(Point01[0], Point01[1], size/3,--cycle);
                DrawPlease(Point10[0], Point10[1], size/3,cycle);
                DrawPlease(Point21[0], Point21[1], size/3,cycle);
                DrawPlease(Point12[0], Point12[1], size/3,cycle);
                

            }

        }
    }
}
