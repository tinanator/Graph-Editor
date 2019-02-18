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
    class PenTool: Tool
    {

        public override void MouseDown(Point mousePos)
        {
            base.MouseDown(mousePos);
            Polyline polyline = new Polyline();
            Global.figures.Add(polyline);
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
                Global.figures.Last().points.Add(mousePos);
            }
            else {
            }
            
        }
    }
}
