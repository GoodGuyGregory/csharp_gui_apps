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

namespace Wpf_INotifyProperty
{
     /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
     public partial class MainWindow : Window
     {
          // creates an instance of the Sum class in the window for the Code to reference the sum behavior
          public Sum SumObj { get; set; }

          public MainWindow()
          {
               InitializeComponent();

               // initialize the sum object with a starting value
               SumObj = new Sum { Num1 = "1", Num2 = "3" };
               this.DataContext = SumObj;


          }
     }
}
