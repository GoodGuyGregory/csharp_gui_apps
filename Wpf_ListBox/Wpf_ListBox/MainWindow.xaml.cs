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

namespace Wpf_ListBox
{
     /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
     public partial class MainWindow : Window
     {
          public MainWindow()
          {
               InitializeComponent();

               //Initialize a List of MAtches
               List<Match> matches = new List<Match>();

               matches.Add(new Match() { Team1 = " Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
               // Challenge Add Additional Matches to the List
               matches.Add(new Match() { Team1 = "Poland", Team2 = "Turkey", Score1 = 7, Score2 = 6, Completion = 75 });
               matches.Add(new Match() { Team1 = "Portugal", Team2 = "Scotland", Score1 = 3, Score2 = 5, Completion = 65 });
               matches.Add(new Match() { Team1 = "Belgium", Team2 = "Cyprus", Score1 = 4, Score2 = 3, Completion = 34 });
               
               // must connect the data to the listbox source "lbMatches" and needs a data source with .ItemSource
               lbMatches.ItemsSource = matches;

          }

          private void Button_Click(object sender, RoutedEventArgs e)
          {
               // intended to show additional information about the selected match details
               if (lbMatches.SelectedItem != null) {
                    MessageBox.Show("Selected Match: " +
                         (lbMatches.SelectedItem as Match).Team1 + " " +
                         (lbMatches.SelectedItem as Match).Score1 + " " +
                         (lbMatches.SelectedItem as Match).Score2 + " " +
                         (lbMatches.SelectedItem as Match).Team2);
               }
          }
     }

     public class Match { 
          public int Score1 { get; set; }
          public int Score2 { get; set; }
          public string Team1 { get; set; }
          public string Team2 { get; set; }
          public int Completion { get; set; }

     }
}
