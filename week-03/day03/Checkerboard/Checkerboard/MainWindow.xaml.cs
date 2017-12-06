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

namespace Checkerboard
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
            
            int size = 20;
            int counter = 0;
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    if (counter % 2 == 0)
                    {
                        foxDraw.FillColor(Colors.Black);
                        foxDraw.DrawRectangle(size * j, size * i, size, size);
                        
                    }
                    else
                    {
                        foxDraw.FillColor(Colors.White);
                        foxDraw.DrawRectangle(size * j, size * i, size, size);
                    }
                    counter++;

                }
                counter++;
            }
        }
    }
}
