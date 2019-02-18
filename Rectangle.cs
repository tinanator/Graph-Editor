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
using System.Drawing;


namespace grapheditor2
{
    class Rectangle : Figure
    {
        public override void Draw(DrawingContext drawingContext)
        {
            
            Rect rect = new Rect();
            rect.X = this.points[this.points.Count - 2].X;
            rect.Y = this.points[this.points.Count - 2].Y;
            double w = this.points[this.points.Count - 1].X - this.points[this.points.Count - 2].X;
            double h = this.points[this.points.Count - 1].Y - this.points[this.points.Count - 2].Y;
            if (w < 0)
            {
                w *= -1;
                
                rect.X = this.points[this.points.Count - 1].X;
            }
            if (h < 0)
            {
                h *= -1;
                rect.Y = this.points[this.points.Count - 1].Y;
               
            }
            
            rect.Width = w;

            rect.Height = h;

            drawingContext.DrawRectangle(new SolidColorBrush(Colors.Transparent), new Pen(new SolidColorBrush(Colors.Black), 1.0), rect);
        }
    }
}
