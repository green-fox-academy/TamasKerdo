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

namespace _13ReproduceThis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            int xStartpoint = 500;
            int yStartpoint = 0;
            int size = 500;
            int cycle = 5;
            DrawPlease(xStartpoint, yStartpoint, size, cycle);


        }


        public void DrawPlease(int xStartpoint, int yStartpoint, int size, int cycle)
        {

            var foxDraw = new FoxDraw(canvas);
            int degrees = 60;
            double angle = Math.PI * degrees / 180.0;
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);

            int pointLenght = size / 2;
            int xLenght = Convert.ToInt32((pointLenght/2) / sinAngle);
            int yLenght = Convert.ToInt32((pointLenght / 2)/ cosAngle);


            int[] Point1 = new int[2];
            Point1[0] = xStartpoint;
            Point1[1] = yStartpoint;

            int[] Point2 = new int[2];
            Point2[0] = xStartpoint + pointLenght;
            Point2[1] = yStartpoint;

            int[] Point3 = new int[2];
            Point3[0] = xStartpoint + 2 * pointLenght;
            Point3[1] = yStartpoint;                    //1sor



            int[] Point4 = new int[2];
            Point4[0] = xStartpoint + 2 * pointLenght + xLenght;
            Point4[1] = yStartpoint + yLenght;                              //ok  

            int[] Point5 = new int[2];
            Point5[0] = xStartpoint + 2 * pointLenght + 2 * xLenght;
            Point5[1] = yStartpoint + 2 * yLenght;

            int[] Point6 = new int[2];
            Point6[0] = xStartpoint + 2 * pointLenght + xLenght;
            Point6[1] = yStartpoint + 3 * yLenght;                    //ok




            int[] Point7 = new int[2];
            Point7[0] = xStartpoint + 2 * pointLenght;
            Point7[1] = yStartpoint + 4 * yLenght;              //ok

            int[] Point8 = new int[2];
            Point8[0] = xStartpoint + pointLenght;
            Point8[1] = yStartpoint + 4 * yLenght;          //ok

            int[] Point9 = new int[2];
            Point9[0] = xStartpoint;
            Point9[1] = yStartpoint + 4 * yLenght;             //ok


            int[] Point10 = new int[2];
            Point10[0] = xStartpoint - xLenght;
            Point10[1] = yStartpoint + 3 * yLenght;               //ok

            int[] Point11 = new int[2];
            Point11[0] = xStartpoint - 2 * xLenght;
            Point11[1] = yStartpoint + 2 * yLenght;        //ok

            int[] Point12 = new int[2];
            Point12[0] = xStartpoint - xLenght;
            Point12[1] = yStartpoint + yLenght;

            int[] Point13 = new int[2];
            Point13[0] = xStartpoint + 1 * pointLenght;
            Point13[1] = yStartpoint + 2 * yLenght;      //center ok


            int[] Point14 = new int[2];
            Point14[0] = xStartpoint;
            Point14[1] = yStartpoint + 2 * yLenght;       //ok

            int[] Point15 = new int[2];
            Point15[0] = xStartpoint + 1 * pointLenght + xLenght;
            Point15[1] = yStartpoint + 2 * yLenght - yLenght;

            int[] Point16 = new int[2];
            Point16[0] = xStartpoint + 1 * pointLenght + xLenght;
            Point16[1] = yStartpoint + 2 * yLenght + yLenght;             //5sor




            foxDraw.DrawLine(Point1[0], Point1[1], Point3[0], Point3[1]);
            foxDraw.DrawLine(Point3[0], Point3[1], Point5[0], Point5[1]);
            foxDraw.DrawLine(Point5[0], Point5[1], Point7[0], Point7[1]);
            foxDraw.DrawLine(Point7[0], Point7[1], Point9[0], Point9[1]);
            foxDraw.DrawLine(Point9[0], Point9[1], Point11[0], Point11[1]);
            foxDraw.DrawLine(Point11[0], Point11[1], Point1[0], Point1[1]);

            foxDraw.DrawLine(Point2[0], Point2[1], Point15[0], Point15[1]);
            foxDraw.DrawLine(Point12[0], Point12[1], Point14[0], Point14[1]);
            foxDraw.DrawLine(Point10[0], Point10[1], Point14[0], Point14[1]);
            foxDraw.DrawLine(Point14[0], Point14[1], Point13[0], Point13[1]);
            foxDraw.DrawLine(Point13[0], Point13[1], Point15[0], Point15[1]);
            foxDraw.DrawLine(Point15[0], Point15[1], Point4[0], Point4[1]);
            foxDraw.DrawLine(Point13[0], Point13[1], Point16[0], Point16[1]);
            foxDraw.DrawLine(Point16[0], Point16[1], Point6[0], Point6[1]);
            foxDraw.DrawLine(Point16[0], Point16[1], Point8[0], Point8[1]);

            size = size / 2; 
            if (cycle > 0)
            {
                DrawPlease(Point1[0], Point1[1], size, --cycle);
                DrawPlease(Point14[0], Point14[1], size, cycle);
                DrawPlease(Point15[0], Point15[1], size, cycle);

            }

        }
    }
}

