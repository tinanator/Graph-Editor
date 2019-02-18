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
    class RectTool : Tool
    {
        Point startPoint;
        public override void MouseDown(Point mousePos)
        {
            startPoint = mousePos; 
            base.MouseDown(mousePos);
            Rectangle rect = new Rectangle();
            Global.figures.Add(rect);
            Global.figures.Last().points.Add(startPoint);
            Global.figures.Last().points.Add(mousePos);

        }
        public override void MouseUp(Point mousePos)
        {
            base.MouseUp(mousePos);
            to_paint = false;
        }
        public override void MouseLeave(Point mousePos)
        {
            base.MouseLeave(mousePos);

        }
        public override void MouseMove(Point mousePos)
        {
            base.MouseMove(mousePos);
            if (to_paint)
            {
                Global.figures.Last().points.RemoveAt(Global.figures.Last().points.Count - 1);
                Global.figures.Last().points.Add(mousePos);
            }
            else
            {
            }

        }
    }
}
