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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        PenTool penTool = new PenTool();
        RectTool rectTool = new RectTool();
        Drawer drawer = new Drawer();
        Tool curTool = null;
        public MainWindow()
        {
           InitializeComponent();
           canvas.Children.Add(drawer);
           curTool = penTool;

        }
  
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = penTool.to_paint ? "true" : "false";
            curTool.MouseMove(Mouse.GetPosition(canvas));
            drawer.Redraw();


        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            curTool.MouseDown(Mouse.GetPosition(canvas));  
            
        }



        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            curTool.MouseUp(Mouse.GetPosition(canvas));
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            curTool.MouseUp(Mouse.GetPosition(canvas));
            drawer.Redraw();
        }

        private void Canvas_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            curTool.MouseDown(Mouse.GetPosition(canvas));
        }

        private void Pen_Click(object sender, RoutedEventArgs e)
        {
            curTool = penTool;
        }

        private void Rect_Click(object sender, RoutedEventArgs e)
        {
            curTool = rectTool;
        }
    }
}
