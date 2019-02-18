using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace grapheditor2
{
    public class Tool
    {
        public bool to_paint = false;
        public virtual void MouseDown(Point mousePos)
        {
            to_paint = true;
        }
        public virtual void MouseUp(Point mousePos)
        {
            to_paint = false;
        }
        public virtual void MouseLeave(Point mousePos)
        {
            to_paint = false;
        }
        public virtual void MouseMove(Point mousePos)
        {
            
        }
    }
}
