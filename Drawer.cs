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
    public class Drawer : FrameworkElement
    {
        private VisualCollection visualcollection;
        public Drawer()
        {
            visualcollection = new VisualCollection(this);
            
        }

        public void Redraw()
        {
            visualcollection.Clear();
            DrawingVisual drawingvisual = new DrawingVisual();
            DrawingContext drawingcontext = drawingvisual.RenderOpen();
            foreach (Figure f in Global.figures)
            {
                f.Draw(drawingcontext);
            }
            drawingcontext.Close();
            visualcollection.Add(drawingvisual);
        }


        protected override int VisualChildrenCount
        {
            get { return visualcollection.Count; }
        }

        // Provide a required override for the GetVisualChild method.
        protected override Visual GetVisualChild(int index)
        {
            if (index < 0 || index >= visualcollection.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return visualcollection[index];
        }

    }
}
