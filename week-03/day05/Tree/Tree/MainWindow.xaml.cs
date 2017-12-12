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

namespace Tree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            int xStartpoint = 300;
            int yStartpoint = 500;
            int size = 50;
            int cycle = 4;
            DrawPlease(xStartpoint, yStartpoint, size, cycle, 1);


        }


        public void DrawPlease(int xStartpoint, int yStartpoint, int size, int cycle, int rightOrLeft)
        {
            var foxDraw = new FoxDraw(canvas);

            // if left branch fi:+ if right branch:- if center:0

            

            
            int degrees = 60;            
            double angle = Math.PI * degrees / 180.0;
            double sinAngle = Math.Sin(angle);
            double cosAngle = Math.Cos(angle);

            int xLenght = Convert.ToInt32((size) / sinAngle);
            int yLenght = Convert.ToInt32((size) / cosAngle);


            int fi = 60;
            int xxLenght = 0;
            int yyLenght = 0;
            double sinFiAngle = 0;
            double cosFiAngle = 0;
            double fiAngle = 0;

            switch (rightOrLeft)
            {
                case 0:

                    fi += fi;
                    fiAngle = Math.PI * fi / 180.0;
                    sinFiAngle = Math.Sin(fiAngle);
                    cosFiAngle = Math.Cos(fiAngle);
                    xxLenght = Convert.ToInt32(((size) / sinAngle) * cosFiAngle);
                    yyLenght = Convert.ToInt32(((size) / cosAngle) * cosFiAngle);
                    break;
                case 1:
                    fi = 0;
                    
                    
                    break;
                case 2:
                    fi -= fi;
                    fiAngle = Math.PI * fi / 180.0;
                    sinFiAngle = Math.Sin(fiAngle);
                    cosFiAngle = Math.Cos(fiAngle);
                    xxLenght = Convert.ToInt32(((size) / sinAngle) * cosFiAngle);
                    yyLenght = Convert.ToInt32(((size) / cosAngle) * cosFiAngle);
                    break;
            }
                       
       


            int[] Point1 = new int[2];
            Point1[0] = xStartpoint;
            Point1[1] = yStartpoint;

            int[] Point2 = new int[2];
            Point2[0] = xStartpoint +xxLenght;
            Point2[1] = yStartpoint -size +yyLenght;

            int[] Point3 = new int[2];
            Point3[0] = xStartpoint+ xxLenght;
            Point3[1] = yStartpoint -2*size + yyLenght;                  
            
            int[] Point4 = new int[2];
            Point4[0] = xStartpoint -xLenght + xxLenght;
            Point4[1] = yStartpoint - size - yLenght + yyLenght;                           

            int[] Point5 = new int[2];
            Point5[0] = xStartpoint +xLenght + xxLenght;
            Point5[1] = yStartpoint + -size - yLenght + yyLenght;

                              
            foxDraw.DrawLine(Point1[0], Point1[1], Point2[0], Point2[1]);
            foxDraw.DrawLine(Point2[0], Point2[1], Point4[0], Point4[1]);
            foxDraw.DrawLine(Point2[0], Point2[1], Point3[0], Point3[1]);
            foxDraw.DrawLine(Point2[0], Point2[1], Point5[0], Point5[1]);



            --cycle;
            if (cycle > 0)
            {
                DrawPlease(Point3[0], Point3[1], size, cycle, 1);
                DrawPlease(Point4[0], Point4[1], size, cycle, 0);
                DrawPlease(Point5[0], Point5[1], size, cycle, 2);


            }

        }
    }
}







