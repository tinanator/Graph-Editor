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
    public class Polyline : Figure
    {
        public override void Draw(DrawingContext drawingContext)
        {
            for (int i = 1; i < points.Count; i++) {
                drawingContext.DrawLine(new Pen(new SolidColorBrush(Colors.Black), 1.0), points[i], points[i - 1]);
            }
            
        }
    }
}
