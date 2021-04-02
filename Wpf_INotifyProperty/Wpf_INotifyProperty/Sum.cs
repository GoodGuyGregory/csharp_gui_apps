using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Wpf_INotifyProperty
{
     public class Sum : INotifyPropertyChanged

     {
          private string num1;
          private string num2;
          private string result;

          public string Num1 {
               get { return num1; }
               set { int number;
                    // try parse will attempt to convert the value to an integer and assign it to value
                    bool res = int.TryParse(value, out number);
                    if (res) {
                         num1 = value;
                    }
                    OnPropertyChanged("Num1");
                    OnPropertyChanged("Result");
               }
          }

          public string Num2
          {
               get { return num2; }
               set
               {
                    int number;
                    // try parse will attempt to convert the value to an integer and assign it to value
                    bool res = int.TryParse(value, out number);
                    if (res)
                    {
                         num2 = value;
                    }
                    OnPropertyChanged("Num2");
                    OnPropertyChanged("Result");
               }
          }

          public string Result
          {
               get {
                    int res = int.Parse(Num1) + int.Parse(Num2);
                    return res.ToString();
               }

               set {
                    int res = int.Parse(Num1) + int.Parse(Num2);
                    result = res.ToString();
                    OnPropertyChanged("Result");
               }

          }
          // this allows C# to change the attributes of the property inside of our onCh anged Method
          public event PropertyChangedEventHandler PropertyChanged;

          private void OnPropertyChanged(string property) {
               if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
          }
     }
}
