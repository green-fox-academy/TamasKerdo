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

namespace Starry_night
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
            
            var rnd = new Random();
            
            int size = 10;

            for (int i = 0; i < 1000; i++)
            {
                int xposition = rnd.Next(1, 2000);
                int yposition = rnd.Next(1, 1000);
                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(), (byte)rnd.Next(), (byte)rnd.Next()));
                
                foxDraw.DrawRectangle(xposition, yposition, size, size);
            }
        }
    }
}
