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

namespace Purple_steps_3D
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
            
            int position = 0;
            int size = 10;
            for (int i = 0; i < 8; i++)
            {               
                foxDraw.FillColor(Colors.Green);
                foxDraw.DrawRectangle(position, position, size, size);
                
                position = position + size;
                size = size * (i + 2);

            }
            
        }
    }
}
