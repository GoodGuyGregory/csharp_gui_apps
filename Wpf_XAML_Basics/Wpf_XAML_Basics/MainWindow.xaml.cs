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

namespace Wpf_XAML_Basics
{
     /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
     public partial class MainWindow : Window
     {
          public MainWindow()
               // This is where it is possible to use C# to code UI elements 
          {
               InitializeComponent();
               // Create a button in C#
               Grid grid = new Grid();
               // Everything within the Window XML is the Content this is referring 
               this.Content = grid;

               Button btn = new Button();
               btn.FontSize = 26;
               btn.Width = 250;
               btn.Height = 100;

               WrapPanel wrapPanel = new WrapPanel();
               // Create a C# Element for an additional TextBlock element
               TextBlock txtblk1 = new TextBlock();
               txtblk1.Text = "Multi";
               // Text color is selected from a brush
               txtblk1.Foreground = Brushes.Blue;
               wrapPanel.Children.Add(txtblk1);

               txtblk1 = new TextBlock();
               txtblk1.Text = "Color";
               // Text color is selected from a brush
               txtblk1.Foreground = Brushes.White;
               wrapPanel.Children.Add(txtblk1);

               txtblk1 = new TextBlock();
               txtblk1.Text = "Button";
               // Text color is selected from a brush
               txtblk1.Foreground = Brushes.Red;
               wrapPanel.Children.Add(txtblk1);

               btn.Content = wrapPanel;
               grid.Children.Add(btn);

          }
     }
}
