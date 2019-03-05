/*Sebastian Horton 
March 1st, 2019
The user inputs an email that is changed to the same email but with the adress "@hotmail"
*/

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

namespace _312551Email
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> adress = new List<string>();
        string output;
        int i;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            output = null;
            string temp;
            string input = txtInput.Text;
            while (i < txtInput.Text.Length)
            {


                temp = input.Substring(i, 1);
                adress.Add(temp);
                //MessageBox.Show(adress[i]);


                if (adress[i].Contains("@"))
                {
                    //MessageBox.Show("STOP");
                    foreach (string adress in adress)
                    {
                        output += adress;
                    }
                    txtInput.Text = (output + "hotmail.com");
                    adress.Clear();
                    return;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
