using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GreenFox
{
    public class FoxDraw
    {
        private int MapElementSize;

        public Canvas Canvas { get; set; }
        public List<Image> Tiles { get; set; }

        public FoxDraw(Canvas canvas, int MapElementSize)
        {
            Canvas = canvas;
            Tiles = new List<Image>();
            this.MapElementSize = MapElementSize;
        }

        public void AddImage(string source, int x, int y)
        {
            var image = new Image()
            {
                Width = MapElementSize,
                Height = MapElementSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Tiles.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, int x, int y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, int x, int y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public int GetLeft(UIElement uIElement)
        {
            return Convert.ToInt32(Canvas.GetLeft(uIElement)) ;
        }

        public int GetTop(UIElement uIElement)
        {
            return Convert.ToInt32(Canvas.GetTop(uIElement));
        }

        public void ClearCanvas()
        {
            Canvas.Children.Clear();
        }
    }
}