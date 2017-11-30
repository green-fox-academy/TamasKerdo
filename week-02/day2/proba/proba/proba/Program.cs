<Window x:Class="Drawing.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d"
        Title="Drawing" Height="331" Width="308">
    <Grid>
        <Canvas Name = "canvas" />
    </ Grid >
</ Window >

using System;
using System.Windows.Controls;
using GreenFox;

namespace Drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
        }
    }
}


public static void DrawGreenLines(FoxDraw foxDraw)
{
    foxDraw.StrokeColor(Colors.Green);
    foxDraw.DrawLine(0, 10, 100, 10);

    var startPoint = new Point(0, 20);
    var endPoint = new Point(100, 20);
    foxDraw.DrawLine(startPoint, endPoint);
}